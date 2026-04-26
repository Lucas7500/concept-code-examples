using SpecificationPattern.Contracts;
using SpecificationPattern.Models;

namespace SpecificationPattern.AfterPatternApplied.Specs;

internal sealed class HasMinimumIncomeSpec(decimal minIncome) : ISpecification<Customer>
{
    public bool IsSatisfiedBy(Customer entity) => entity.Income > minIncome;
}
