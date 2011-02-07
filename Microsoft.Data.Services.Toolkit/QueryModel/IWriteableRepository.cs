namespace Microsoft.Data.Services.Toolkit.QueryModel
{
    /// <summary>
    /// Defines the contract for write operations.
    /// </summary>
    public interface IWriteableRepository
    {
        /// <summary>
        /// Creates the default entity.
        /// </summary>
        /// <returns>A new entity set with default values.</returns>
        object CreateDefaultEntity();

        /// <summary>
        /// Removes a given entity.
        /// </summary>
        /// <param name="entity">The entity to be removed.</param>
        void Remove(object entity);

        /// <summary>
        /// Persists the entity changes.
        /// </summary>
        /// <param name="entity">The entity with changes.</param>
        void Save(object entity);

        /// <summary>
        /// Creates a relation between two entities.
        /// </summary>
        /// <param name="targetResource">The target entity.</param>
        /// <param name="resourceToBeAdded">The resource to be added.</param>
        void CreateRelation(object targetResource, object resourceToBeAdded);
    }
}