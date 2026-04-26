using PolicyPattern.Contracts;
using PolicyPattern.Models;

namespace PolicyPattern.AfterPatternApplied;

/// <summary>
/// Refactored service that uses a collection of policies to determine the best discount.
/// Now implements IDiscountService to match the "Before" service contract.
/// </summary>
internal sealed class DiscountServiceAfter(IEnumerable<IDiscountPolicy> policies) : IDiscountService
{
    public decimal CalculateFinalAmount(Order order)
    {
        var applicableDiscounts = policies.Select(p => p.GetDiscountRate(order));
        
        var bestDiscountRate = applicableDiscounts.Max();

        return order.TotalAmount - (order.TotalAmount * bestDiscountRate);
    }
}
