using SpecificationPattern.Contracts;
using SpecificationPattern.Models;

namespace SpecificationPattern.AfterPatternApplied.Specs;

internal sealed class IsMidTermCustomerSpec(DateTime now) : ISpecification<Customer>
{
    public bool IsSatisfiedBy(Customer entity) => entity.AccountCreationDate < now.AddYears(-3);
}
