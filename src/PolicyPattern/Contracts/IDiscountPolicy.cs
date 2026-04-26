using PolicyPattern.Models;

namespace PolicyPattern.Contracts;

/// <summary>
/// Defines a pluggable business rule that contributes to the final discount calculation.
/// </summary>
internal interface IDiscountPolicy
{
    /// <summary>
    /// Determines the specific discount percentage applicable to the order based on this policy's rules.
    /// </summary>
    /// <param name="order">The order to evaluate.</param>
    /// <returns>A decimal representing the discount rate (e.g., 0.15 for 15%).</returns>
    decimal GetDiscountRate(Order order);
}