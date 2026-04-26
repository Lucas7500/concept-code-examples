namespace PolicyPattern.Constants;

/// <summary>
/// Centralizes all magic numbers for discount calculations.
/// Using constants or static readonly fields prevents duplication and 
/// makes business rule changes trivial to implement.
/// </summary>
internal static class DiscountConstants
{
    public const int BlackFridayMonth = 11;
    public const int BlackFridayDay = 25;

    public const decimal EmployeeDiscountRate = 0.30m;
    public const decimal VipDiscountRate = 0.15m;
    public const decimal BlackFridayDiscountRate = 0.25m;
    public const decimal BulkDiscountRate = 0.05m;

    public const decimal BulkPurchaseThreshold = 1000m;
}
