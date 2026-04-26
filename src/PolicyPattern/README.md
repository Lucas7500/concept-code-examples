# Policy Pattern

The Policy Pattern is used to encapsulate variable business rules, decisions, or calculations that depend on a specific context.

## Problem
In complex systems, business rules (like "how to calculate a discount") often depend on many factors (customer type, date, amount, region). Implementing these directly in a service leads to:
- **Massive Switch/If-Else blocks**: Hard to read and maintain.
- **Violation of Open/Closed Principle**: You must change the service every time a rule changes or a new one is added.
- **Hard to Test**: Testing one rule requires setting up a state that avoids other rules.

## Solution
Abstract the decision or calculation into a "Policy" object. The service then consumes a collection of policies or selects the appropriate one at runtime.

## Key Differences from Specification Pattern
- **Specification**: Returns a boolean (`true`/`false`). It answers: "Does this object satisfy the rule?"
- **Policy**: Returns a value, an action, or a calculated result. It answers: "What is the result of applying this rule?"

## Benefits in this Project
1. **Open/Closed Principle**: We added a `FlashSalePolicy` in `Program.cs` without touching the `DiscountServiceAfter` class.
2. **High Testability**: Each policy can be unit tested individually.
3. **Contextual Decisions**: The service can decide how to resolve multiple policies (e.g., `Max()`, `Sum()`, or `First()`).

## Example
- **Before**: `DiscountServiceBefore.cs` contains the nested `if-else` for all customer types and dates.
- **After**: Rules are moved to `Policies/DiscountPolicies.cs` and injected into `DiscountServiceAfter.cs`.
