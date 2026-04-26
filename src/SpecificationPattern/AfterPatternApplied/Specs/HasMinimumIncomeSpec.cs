using SpecificationPattern.Contracts;
using SpecificationPattern.Models;

namespace SpecificationPattern.AfterPatternApplied.Specs;

/// <summary>
/// Ensures the customer has a stable financial base by verifying their monthly income against a minimum threshold.
/// </summary>
internal sealed class HasMinimumIncomeSpec(decimal minIncome) : ISpecification<Customer>
{
    public bool IsSatisfiedBy(Customer entity) => entity.Income > minIncome;
}