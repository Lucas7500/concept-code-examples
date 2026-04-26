using SpecificationPattern.Constants;
using SpecificationPattern.Contracts;
using SpecificationPattern.Models;

namespace SpecificationPattern.AfterPatternApplied.Specs;

/// <summary>
/// Identifies new or recent customers where risk exposure is kept at a minimum.
/// </summary>
internal sealed class IsShortTermCustomerSpec(DateTime now) : ISpecification<Customer>
{
    public bool IsSatisfiedBy(Customer entity) => 
        entity.AccountCreationDate <= now.AddYears(-CreditRules.ShortTermYearsThreshold);
}