using SpecificationPattern.Contracts;

namespace SpecificationPattern.AfterPatternApplied;

/// <summary>
/// Provides extension methods for composing specifications.
/// Standardized with expression-bodied members for clean, functional-style composition.
/// </summary>
internal static class SpecificationExtensions
{
    public static ISpecification<T> And<T>(this ISpecification<T> left, ISpecification<T> right) where T : class 
        => new AndSpecification<T>(left, right);

    public static ISpecification<T> Or<T>(this ISpecification<T> left, ISpecification<T> right) where T : class 
        => new OrSpecification<T>(left, right);

    public static ISpecification<T> Not<T>(this ISpecification<T> spec) where T : class 
        => new NotSpecification<T>(spec);

    private sealed class AndSpecification<T>(ISpecification<T> left, ISpecification<T> right) : ISpecification<T> where T : class
    {
        public bool IsSatisfiedBy(T entity) => left.IsSatisfiedBy(entity) && right.IsSatisfiedBy(entity);
    }

    private sealed class OrSpecification<T>(ISpecification<T> left, ISpecification<T> right) : ISpecification<T> where T : class
    {
        public bool IsSatisfiedBy(T entity) => left.IsSatisfiedBy(entity) || right.IsSatisfiedBy(entity);
    }

    private sealed class NotSpecification<T>(ISpecification<T> spec) : ISpecification<T> where T : class
    {
        public bool IsSatisfiedBy(T entity) => !spec.IsSatisfiedBy(entity);
    }
}
