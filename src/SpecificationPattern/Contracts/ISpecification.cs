namespace SpecificationPattern.Contracts
{
    /// <summary>
    /// Defines the contract for a Specification in the Specification Pattern.
    /// This pattern allows encapsulating business rules into reusable, composable objects.
    /// </summary>
    /// <typeparam name="T">The type of object this specification applies to.</typeparam>
    internal interface ISpecification<in T> where T : class
    {
        /// <summary>
        /// Evaluates the specification against a specific object.
        /// </summary>
        /// <param name="entity">The object to be evaluated.</param>
        /// <returns>True if the object satisfies the specification; otherwise, false.</returns>
        bool IsSatisfiedBy(T entity);
    }
}
