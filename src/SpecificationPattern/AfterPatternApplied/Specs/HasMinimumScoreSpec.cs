using SpecificationPattern.Contracts;
using SpecificationPattern.Models;

namespace SpecificationPattern.AfterPatternApplied.Specs;

/// <summary>
/// Validates the customer's creditworthiness based on their historical credit score.
/// </summary>
internal sealed class HasMinimumScoreSpec(int minScore) : ISpecification<Customer>
{
    public bool IsSatisfiedBy(Customer entity) => entity.Score > minScore;
}