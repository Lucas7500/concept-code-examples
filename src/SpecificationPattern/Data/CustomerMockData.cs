using SpecificationPattern.Models;

namespace SpecificationPattern.Data;

/// <summary>
/// Object Mother Pattern: Provides a centralized place to create mock objects for tests and demos.
/// This prevents code duplication when the same types of objects are needed in multiple places.
/// </summary>
internal static class CustomerMockData
{
    public static Customer CreateEligibleLongTermCustomer() => new()
    {
        Name = "John Doe",
        IsActive = true,
        HasDebt = false,
        Income = 5000,
        Score = 700,
        AccountCreationDate = DateTime.UtcNow.AddYears(-6) // Long term (> 5 years)
    };

    public static Customer CreateIneligibleDebtCustomer() => new()
    {
        Name = "Jane Doe",
        IsActive = true,
        HasDebt = true,
        Income = 800,
        Score = 400,
        AccountCreationDate = DateTime.UtcNow.AddYears(-2) // Mid term (between 1 and 3 years)
    };

    public static Customer CreateActiveHighIncomeCustomer() => new()
    {
        Name = "Richie Rich",
        IsActive = true,
        HasDebt = false,
        Income = 10000,
        Score = 850,
        AccountCreationDate = DateTime.UtcNow.AddMonths(-6) // Short term (< 1 year)
    };
}
