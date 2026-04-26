using SpecificationPattern.AfterPatternApplied.Specs;
using SpecificationPattern.Constants;
using SpecificationPattern.Contracts;
using SpecificationPattern.Models;

namespace SpecificationPattern.AfterPatternApplied;

/// <summary>
/// Implementation of ICustomerService using the Specification Pattern.
/// Standardized with file-scoped namespace and clean conditional logic using constants.
/// </summary>
internal sealed class CustomerServiceAfter : ICustomerService
{
    public void ReleaseCreditLimit(Customer customer)
    {
        if (!new CanCustomerGetCreditSpec().IsSatisfiedBy(customer))
            return;

        var now = DateTime.UtcNow;

        if (new IsLongTermCustomerSpec(now).IsSatisfiedBy(customer))
        {
            customer.CreditLimit = customer.Income * CreditRules.LongTermCreditMultiplier;
        }
        else if (new IsMidTermCustomerSpec(now).IsSatisfiedBy(customer))
        {
            customer.CreditLimit = customer.Income * CreditRules.MidTermCreditMultiplier;
        }
        else if (new IsShortTermCustomerSpec(now).IsSatisfiedBy(customer))
        {
            customer.CreditLimit = customer.Income * CreditRules.ShortTermCreditMultiplier;
        }
    }
}