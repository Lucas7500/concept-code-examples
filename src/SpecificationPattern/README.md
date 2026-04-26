# Specification Pattern

The Specification Pattern is a behavioral design pattern used to encapsulate business rules into reusable, composable, and testable objects.

## Problem
In many applications, business rules (like validation or selection criteria) are often scattered throughout the codebase—within services, controllers, or repositories. This leads to:
- **Code Duplication:** The same logic is repeated in multiple places.
- **Low Maintainability:** Changing a rule requires finding and updating all its occurrences.
- **Poor Testability:** Testing complex logic tied to services often requires heavy mocking.

## Solution
Encapsulate each rule into a "Specification" class that implements a simple interface: `bool IsSatisfiedBy(T entity)`.

## Structure
- `ISpecification<T>`: The core interface.
- `Atomic Specifications`: Small, focused classes that check a single rule (e.g., `IsCustomerActiveSpec`).
- `Composite Specifications`: Combinations of atomic specs using logical operators (`And`, `Or`, `Not`).
- `Extension Methods`: Used to provide a fluent API for composing specs.

## Benefits
1. **Reusability:** Use the same specification for validation, querying, and business logic.
2. **Readability:** Business rules are explicit and named (e.g., `new CanCustomerGetCreditSpec()`).
3. **Testability:** Each specification can be unit tested in isolation.
4. **Decoupling:** Services don't need to know *how* a rule is evaluated, only *if* it is satisfied.

## Example in this Project
- **Before:** Logic is hardcoded inside `CustomerServiceBefore`.
- **After:** Logic is moved to classes in `Specs/` and composed fluently in `CustomerServiceAfter`.
