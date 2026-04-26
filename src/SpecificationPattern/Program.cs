using SpecificationPattern.AfterPatternApplied;
using SpecificationPattern.AfterPatternApplied.Specs;
using SpecificationPattern.BeforePatternApplied;
using SpecificationPattern.Data;

var eligibleCustomer = CustomerMockData.CreateEligibleLongTermCustomer();
var ineligibleCustomer = CustomerMockData.CreateIneligibleDebtCustomer();
var vipCandidate = CustomerMockData.CreateActiveHighIncomeCustomer();

Console.WriteLine("--- Comparison Demo ---");

var serviceBefore = new CustomerServiceBefore();
serviceBefore.ReleaseCreditLimit(eligibleCustomer);

Console.WriteLine($"Before Pattern - {eligibleCustomer.Name}: {eligibleCustomer.CreditLimit:C}");

eligibleCustomer.CreditLimit = 0; // Reset

var serviceAfter = new CustomerServiceAfter();
serviceAfter.ReleaseCreditLimit(eligibleCustomer);

Console.WriteLine($"After Pattern  - {eligibleCustomer.Name}: {eligibleCustomer.CreditLimit:C}");

Console.WriteLine("\n--- Composition Demo ---");

var isVipSpec = new HasMinimumIncomeSpec(8000)
    .And(new HasMinimumScoreSpec(700))
    .And(new IsCustomerActiveSpec());

bool isVip = isVipSpec.IsSatisfiedBy(vipCandidate);
Console.WriteLine($"Is {vipCandidate.Name} a VIP? {isVip}");

bool isNotVip = isVipSpec.Not().IsSatisfiedBy(ineligibleCustomer);
Console.WriteLine($"Is {ineligibleCustomer.Name} NOT a VIP? {isNotVip}");
