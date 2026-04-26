using PolicyPattern.AfterPatternApplied;
using PolicyPattern.AfterPatternApplied.Policies;
using PolicyPattern.BeforePatternApplied;
using PolicyPattern.Contracts;
using PolicyPattern.Data;
using PolicyPattern.Models;

Console.WriteLine("--- Policy Pattern Demo ---\n");

var vipOrder = OrderMockData.CreateVipOrder();
var bfOrder = OrderMockData.CreateBlackFridayOrder();

var serviceBefore = new DiscountServiceBefore();
Console.WriteLine("Scenario: VIP Customer");
Console.WriteLine($"[Before] Final Amount: {serviceBefore.CalculateFinalAmount(vipOrder):C}");

var policies = new List<IDiscountPolicy>
{
    new EmployeeDiscountPolicy(),
    new VipDiscountPolicy(),
    new BlackFridayPolicy(),
    new BulkPurchasePolicy()
};

var serviceAfter = new DiscountServiceAfter(policies);
Console.WriteLine($"[After ] Final Amount: {serviceAfter.CalculateFinalAmount(vipOrder):C}");

Console.WriteLine("\nScenario: Black Friday Campaign");
Console.WriteLine($"[Before] Final Amount: {serviceBefore.CalculateFinalAmount(bfOrder):C}");
Console.WriteLine($"[After ] Final Amount: {serviceAfter.CalculateFinalAmount(bfOrder):C}");

Console.WriteLine("\n--- Flexibility Demo ---");
Console.WriteLine("Adding a new 'Flash Sale' Policy without modifying existing services...");

var flashSalePolicy = new FlashSalePolicy();
var updatedPolicies = new List<IDiscountPolicy>(policies) { flashSalePolicy };
var flexibleService = new DiscountServiceAfter(updatedPolicies);

var flashSaleOrder = new Order 
{ 
    Customer = new Customer { Name = "Eve" }, 
    TotalAmount = 100, 
    OrderDate = DateTime.UtcNow 
};

Console.WriteLine($"Order with Flash Sale (50% off): {flexibleService.CalculateFinalAmount(flashSaleOrder):C}");

internal sealed class FlashSalePolicy : IDiscountPolicy
{
    public decimal GetDiscountRate(Order order) => 0.50m;
}
