using SpecificationPattern.Contracts;
using SpecificationPattern.Models;

namespace SpecificationPattern.AfterPatternApplied.Specs;

/// <summary>
/// Verifies that the customer's account is currently in good standing and not suspended.
/// </summary>
internal sealed class IsCustomerActiveSpec : ISpecification<Customer>
{
    public bool IsSatisfiedBy(Customer entity) => entity.IsActive;
}