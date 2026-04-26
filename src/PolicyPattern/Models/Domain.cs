namespace PolicyPattern.Models;

/// <summary>
/// Holds the necessary attributes to determine eligibility for various discount tiers.
/// </summary>
internal sealed class Customer
{
    public string Name { get; init; } = string.Empty;
    public bool IsVip { get; init; }
    public bool IsEmployee { get; init; }
}

/// <summary>
/// Contains transactional data required by discount policies to calculate the final price.
/// </summary>
internal sealed class Order
{
    public Customer Customer { get; init; } = new();
    public decimal TotalAmount { get; init; }
    public DateTime OrderDate { get; init; }
}