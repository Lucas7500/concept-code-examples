using SpecificationPattern.Constants;
using SpecificationPattern.Contracts;
using SpecificationPattern.Models;

namespace SpecificationPattern.AfterPatternApplied.Specs;

/// <summary>
/// A composite specification that defines the rules for a customer to be eligible for credit.
/// Uses centralized constants for business thresholds.
/// </summary>
internal sealed class CanCustomerGetCreditSpec : ISpecification<Customer>
{
    public bool IsSatisfiedBy(Customer entity) => 
        new IsCustomerActiveSpec()
            .And(new HasMinimumScoreSpec(CreditRules.MinimumCreditScore))
            .And(new HasNoDebtSpec())
            .And(new HasMinimumIncomeSpec(CreditRules.MinimumMonthlyIncome))
            .IsSatisfiedBy(entity);
}
