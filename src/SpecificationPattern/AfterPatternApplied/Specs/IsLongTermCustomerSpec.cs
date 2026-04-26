using SpecificationPattern.Constants;
using SpecificationPattern.Contracts;
using SpecificationPattern.Models;

namespace SpecificationPattern.AfterPatternApplied.Specs;

/// <summary>
/// Identifies customers with a significant history, allowing for the highest level of trust and credit limits.
/// </summary>
internal sealed class IsLongTermCustomerSpec(DateTime now) : ISpecification<Customer>
{
    public bool IsSatisfiedBy(Customer entity) => 
        entity.AccountCreationDate <= now.AddYears(-CreditRules.LongTermYearsThreshold);
}