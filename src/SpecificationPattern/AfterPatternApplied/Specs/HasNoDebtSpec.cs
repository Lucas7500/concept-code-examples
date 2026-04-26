using SpecificationPattern.Contracts;
using SpecificationPattern.Models;

namespace SpecificationPattern.AfterPatternApplied.Specs;

internal sealed class HasNoDebtSpec : ISpecification<Customer>
{
    public bool IsSatisfiedBy(Customer entity) => !entity.HasDebt;
}
