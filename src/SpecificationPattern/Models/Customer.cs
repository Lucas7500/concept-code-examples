namespace SpecificationPattern.Models;

/// <summary>
/// Represents a customer in the system.
/// </summary>
internal class Customer
{
    public string Name { get; init; } = string.Empty;
    public bool IsActive { get; init; }
    public int Score { get; init; }
    public bool HasDebt { get; init; }
    public decimal Income { get; init; }
    public decimal CreditLimit { get; set; }
    public DateTime AccountCreationDate { get; init; }
}
