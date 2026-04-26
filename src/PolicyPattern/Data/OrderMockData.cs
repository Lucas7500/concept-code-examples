using PolicyPattern.Models;

namespace PolicyPattern.Data;

/// <summary>
/// Object Mother Pattern: Centralizes mock data creation for the Policy Pattern demo.
/// </summary>
internal static class OrderMockData
{
    public static Order CreateVipOrder() => new()
    {
        Customer = new Customer { Name = "Alice", IsVip = true },
        TotalAmount = 500m,
        OrderDate = DateTime.UtcNow
    };

    public static Order CreateEmployeeOrder() => new()
    {
        Customer = new Customer { Name = "Bob", IsEmployee = true },
        TotalAmount = 100m,
        OrderDate = DateTime.UtcNow
    };

    public static Order CreateBlackFridayOrder() => new()
    {
        Customer = new Customer { Name = "Charlie" },
        TotalAmount = 200m,
        OrderDate = new DateTime(DateTime.UtcNow.Year, 11, 25, 0, 0, 0, DateTimeKind.Utc)
    };

    public static Order CreateStandardBulkOrder() => new()
    {
        Customer = new Customer { Name = "Dave" },
        TotalAmount = 2000m,
        OrderDate = DateTime.UtcNow
    };
}
