using SpecificationPattern.Contracts;
using SpecificationPattern.Models;

namespace SpecificationPattern.AfterPatternApplied.Specs;

internal sealed class IsLongTermCustomerSpec(DateTime now) : ISpecification<Customer>
{
    public bool IsSatisfiedBy(Customer entity) => entity.AccountCreationDate < now.AddYears(-5);
}
