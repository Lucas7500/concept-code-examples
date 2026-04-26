using SpecificationPattern.Contracts;
using SpecificationPattern.Models;

namespace SpecificationPattern.BeforePatternApplied;

/// <summary>
/// Traditional implementation with hardcoded rules and private methods.
/// Standardized with expression-bodied members.
/// </summary>
internal sealed class CustomerServiceBefore : ICustomerService
{
    public void ReleaseCreditLimit(Customer customer)
    {
        if (!CanGetCreditLimit(customer))
            return;
        
        var now = DateTime.UtcNow;

        if (IsShortTermCustomer(now, customer))
            customer.CreditLimit = customer.Income * 0.9m;
        
        if (IsMidTermCustomer(now, customer))
            customer.CreditLimit = customer.Income * 1.5m;

        if (IsLongTermCustomer(now, customer))
            customer.CreditLimit = customer.Income * 3.0m;
    }

    public static bool CanGetCreditLimit(Customer client) =>
        client.IsActive
            && client.Score > 500
            && !client.HasDebt
            && client.Income > 1000;

    private static bool IsShortTermCustomer(DateTime now, Customer client) =>
        client.AccountCreationDate < now.AddYears(-1);
    
    private static bool IsMidTermCustomer(DateTime now, Customer client) =>
        client.AccountCreationDate < now.AddYears(-3);

    private static bool IsLongTermCustomer(DateTime now, Customer client) =>
        client.AccountCreationDate < now.AddYears(-5);
}
