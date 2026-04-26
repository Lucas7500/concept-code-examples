using SpecificationPattern.Contracts;
using SpecificationPattern.Models;

namespace SpecificationPattern.AfterPatternApplied.Specs;

internal sealed class IsCustomerActiveSpec : ISpecification<Customer>
{
    public bool IsSatisfiedBy(Customer entity) => entity.IsActive;
}
