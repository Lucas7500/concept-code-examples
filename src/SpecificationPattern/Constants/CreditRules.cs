namespace SpecificationPattern.Constants;

/// <summary>
/// Centralizes all magic numbers related to credit evaluation rules.
/// </summary>
internal static class CreditRules
{
    public const int MinimumCreditScore = 500;
    public const decimal MinimumMonthlyIncome = 1000m;
    
    public const int ShortTermYearsThreshold = 1;
    public const int MidTermYearsThreshold = 3;
    public const int LongTermYearsThreshold = 5;

    public const decimal ShortTermCreditMultiplier = 0.9m;
    public const decimal MidTermCreditMultiplier = 1.5m;
    public const decimal LongTermCreditMultiplier = 3.0m;
}