using SpecificationPattern.Constants;
using SpecificationPattern.Contracts;
using SpecificationPattern.Models;

namespace SpecificationPattern.AfterPatternApplied.Specs;

/// <summary>
/// Identifies customers with moderate history to balance risk with rewarding loyalty.
/// </summary>
internal sealed class IsMidTermCustomerSpec(DateTime now) : ISpecification<Customer>
{
    public bool IsSatisfiedBy(Customer entity) => 
        entity.AccountCreationDate <= now.AddYears(-CreditRules.MidTermYearsThreshold);
}