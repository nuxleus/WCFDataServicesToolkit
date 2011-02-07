namespace Microsoft.Data.Services.Toolkit.QueryModel
{
    using System.Collections.Generic;

    /// <summary>
    /// Defines the contract for read operations.
    /// </summary>
    /// <typeparam name="T">The entity type.</typeparam>
    public interface IRepository<T>
    {
        /// <summary>
        /// Returns all collection items.
        /// </summary>
        /// <returns>An IEnumerable containing every collection item.</returns>
        IEnumerable<T> GetAll();
            
        /// <summary>
        /// Returns a specified item based on its identifier.
        /// </summary>
        /// <param name="key">The item identifier.</param>
        /// <returns>The specified collection item.</returns>
        T GetOne(string key);
    }
}
