namespace SpecificationPattern.Contracts;

/// <summary>
/// Encapsulates a business rule as a first-class object, enabling complex logic to be 
/// composed, reused, and tested in isolation.
/// </summary>
/// <typeparam name="T">The type of object this specification applies to.</typeparam>
internal interface ISpecification<in T> where T : class
{
    /// <summary>
    /// Checks if the provided entity fulfills the criteria defined by this rule.
    /// </summary>
    /// <param name="entity">The object to be evaluated.</param>
    /// <returns>True if the object satisfies the specification; otherwise, false.</returns>
    bool IsSatisfiedBy(T entity);
}