using SpecificationPattern.Contracts;
using SpecificationPattern.Models;

namespace SpecificationPattern.AfterPatternApplied.Specs;

/// <summary>
/// Mitigates risk by ensuring the customer does not have any currently registered debt.
/// </summary>
internal sealed class HasNoDebtSpec : ISpecification<Customer>
{
    public bool IsSatisfiedBy(Customer entity) => !entity.HasDebt;
}