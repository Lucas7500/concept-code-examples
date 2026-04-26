using PolicyPattern.Constants;
using PolicyPattern.Contracts;
using PolicyPattern.Models;

namespace PolicyPattern.BeforePatternApplied;

/// <summary>
/// Traditional implementation where all discount rules are hardcoded inside the service.
/// Refactored to implement IDiscountService and use constants instead of magic numbers.
/// </summary>
internal sealed class DiscountServiceBefore : IDiscountService
{
    public decimal CalculateFinalAmount(Order order)
    {
        decimal discountPercentage = 0;

        if (order.Customer.IsEmployee)
        {
            discountPercentage = DiscountConstants.EmployeeDiscountRate;
        }
        else if (order.Customer.IsVip)
        {
            discountPercentage = DiscountConstants.VipDiscountRate;
        }
        else if (order.OrderDate.Month == DiscountConstants.BlackFridayMonth && 
                 order.OrderDate.Day == DiscountConstants.BlackFridayDay)
        {
            discountPercentage = DiscountConstants.BlackFridayDiscountRate;
        }
        else if (order.TotalAmount > DiscountConstants.BulkPurchaseThreshold)
        {
            discountPercentage = DiscountConstants.BulkDiscountRate;
        }

        return order.TotalAmount - (order.TotalAmount * discountPercentage);
    }
}
