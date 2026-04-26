using PolicyPattern.Constants;
using PolicyPattern.Contracts;
using PolicyPattern.Models;

namespace PolicyPattern.AfterPatternApplied.Policies;

/// <summary>
/// Encapsulates the business rule that rewards company employees with a special discount rate.
/// </summary>
internal sealed class EmployeeDiscountPolicy : IDiscountPolicy
{
    public decimal GetDiscountRate(Order order) => 
        order.Customer.IsEmployee ? DiscountConstants.EmployeeDiscountRate : 0m;
}

/// <summary>
/// rewards high-value customers identified as VIPs with a loyalty-based discount.
/// </summary>
internal sealed class VipDiscountPolicy : IDiscountPolicy
{
    public decimal GetDiscountRate(Order order) => 
        order.Customer.IsVip ? DiscountConstants.VipDiscountRate : 0m;
}

/// <summary>
/// Implements volatile seasonal pricing strategy by applying a specific rate during the Black Friday window.
/// </summary>
internal sealed class BlackFridayPolicy : IDiscountPolicy
{
    public decimal GetDiscountRate(Order order) => 
        order.OrderDate is { Month: DiscountConstants.BlackFridayMonth, Day: DiscountConstants.BlackFridayDay } 
            ? DiscountConstants.BlackFridayDiscountRate 
            : 0m;
}

/// <summary>
/// Encourages larger purchases by applying a discount once a specific order total threshold is exceeded.
/// </summary>
internal sealed class BulkPurchasePolicy : IDiscountPolicy
{
    public decimal GetDiscountRate(Order order) => 
        order.TotalAmount > DiscountConstants.BulkPurchaseThreshold ? DiscountConstants.BulkDiscountRate : 0m;
}
