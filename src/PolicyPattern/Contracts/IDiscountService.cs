using PolicyPattern.Models;

namespace PolicyPattern.Contracts;

/// <summary>
/// Provides a unified interface for calculating final order amounts, allowing for seamless
/// transition between hardcoded logic and pattern-based implementations.
/// </summary>
internal interface IDiscountService
{
    decimal CalculateFinalAmount(Order order);
}