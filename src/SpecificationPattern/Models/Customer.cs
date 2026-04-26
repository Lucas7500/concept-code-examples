namespace SpecificationPattern.Models;

/// <summary>
/// Aggregates the financial and history data needed to evaluate credit specifications.
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