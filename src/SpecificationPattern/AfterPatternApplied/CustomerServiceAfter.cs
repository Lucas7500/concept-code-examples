using SpecificationPattern.AfterPatternApplied.Specs;
using SpecificationPattern.Contracts;
using SpecificationPattern.Models;

namespace SpecificationPattern.AfterPatternApplied;

/// <summary>
/// Implementation of ICustomerService using the Specification Pattern.
/// </summary>
internal sealed class CustomerServiceAfter : ICustomerService
{
    public void ReleaseCreditLimit(Customer customer)
    {
        if (!new CanCustomerGetCreditSpec().IsSatisfiedBy(customer))
            return;

        var now = DateTime.UtcNow;

        if (new IsShortTermCustomerSpec(now).IsSatisfiedBy(customer))
            customer.CreditLimit = customer.Income * 0.9m;

        if (new IsMidTermCustomerSpec(now).IsSatisfiedBy(customer))
            customer.CreditLimit = customer.Income * 1.5m;

        if (new IsLongTermCustomerSpec(now).IsSatisfiedBy(customer))
            customer.CreditLimit = customer.Income * 3.0m;
    }
}
