using SpecificationPattern.Contracts;
using SpecificationPattern.Models;

namespace SpecificationPattern.AfterPatternApplied.Specs;

/// <summary>
/// A composite specification that defines the rules for a customer to be eligible for credit.
/// Standardized with expression-bodied member for composition.
/// </summary>
internal sealed class CanCustomerGetCreditSpec : ISpecification<Customer>
{
    /// <summary>
    /// If you think it's too much complexity to have so many small specifications, you can create a composite specification that combines them into a single one. 
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    public bool IsSatisfiedBy(Customer entity) => 
        new IsCustomerActiveSpec()
            .And(new HasMinimumScoreSpec(500))
            .And(new HasNoDebtSpec())
            .And(new HasMinimumIncomeSpec(1000))
            .IsSatisfiedBy(entity);
}
