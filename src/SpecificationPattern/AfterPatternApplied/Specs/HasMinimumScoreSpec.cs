using SpecificationPattern.Contracts;
using SpecificationPattern.Models;

namespace SpecificationPattern.AfterPatternApplied.Specs;

internal sealed class HasMinimumScoreSpec(int minScore) : ISpecification<Customer>
{
    public bool IsSatisfiedBy(Customer entity) => entity.Score > minScore;
}
