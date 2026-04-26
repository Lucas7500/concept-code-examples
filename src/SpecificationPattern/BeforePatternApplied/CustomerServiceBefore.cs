using SpecificationPattern.Constants;
using SpecificationPattern.Contracts;
using SpecificationPattern.Models;

namespace SpecificationPattern.BeforePatternApplied;

/// <summary>
/// Traditional implementation with hardcoded rules and private methods.
/// Refactored to use CreditRules constants for both thresholds and multipliers.
/// </summary>
internal sealed class CustomerServiceBefore : ICustomerService
{
    public void ReleaseCreditLimit(Customer customer)
    {
        if (!CanGetCreditLimit(customer))
            return;
        
        var now = DateTime.UtcNow;

        if (IsLongTermCustomer(now, customer))
        {
            customer.CreditLimit = customer.Income * CreditRules.LongTermCreditMultiplier;
        }
        else if (IsMidTermCustomer(now, customer))
        {
            customer.CreditLimit = customer.Income * CreditRules.MidTermCreditMultiplier;
        }
        else if (IsShortTermCustomer(now, customer))
        {
            customer.CreditLimit = customer.Income * CreditRules.ShortTermCreditMultiplier;
        }
    }

    public bool CanGetCreditLimit(Customer client) =>
        client.IsActive
        && client.Score > CreditRules.MinimumCreditScore
        && !client.HasDebt
        && client.Income > CreditRules.MinimumMonthlyIncome;

    private static bool IsShortTermCustomer(DateTime now, Customer client) =>
        client.AccountCreationDate <= now.AddYears(-CreditRules.ShortTermYearsThreshold);
    
    private static bool IsMidTermCustomer(DateTime now, Customer client) =>
        client.AccountCreationDate <= now.AddYears(-CreditRules.MidTermYearsThreshold);

    private static bool IsLongTermCustomer(DateTime now, Customer client) =>
        client.AccountCreationDate <= now.AddYears(-CreditRules.LongTermYearsThreshold);
}