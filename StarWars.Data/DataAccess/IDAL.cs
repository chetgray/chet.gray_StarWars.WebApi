using System.Collections.Generic;
using System.Data;

namespace StarWars.Data.DataAccess
{
    /// <summary>The data access between the data layer and the database.</summary>
    public interface IDAL
    {
        /// <summary>Executes a stored procedure with parameters.</summary>
        /// <param name="storedProcedureName">
        ///     The name of the stored procedure to execute.
        /// </param>
        /// <param name="parameters">
        ///     The <see cref="Dictionary{string, object}">collection</see> of parameters to
        ///     pass.
        /// </param>
        void ExecuteStoredProcedure(
            string storedProcedureName,
            Dictionary<string, object> parameters
        );

        /// <inheritdoc cref="ExecuteStoredProcedure(string, Dictionary{string, object})"/>
        /// <summary>
        ///     Executes a stored procedure with parameters, returning a single value.
        /// </summary>
        /// <returns>The single scalar value returned from the stored procedure.</returns>
        object GetValueFromStoredProcedure(
            string storedProcedureName,
            Dictionary<string, object> parameters
        );

        /// <inheritdoc cref="ExecuteStoredProcedure(string, Dictionary{string, object})"/>
        /// <summary>
        ///     Executes a stored procedure with parameters, returning a <see
        ///     cref="DataTable">table</see>.
        /// </summary>
        /// <returns>
        ///     The first <see cref="DataTable">table</see> in the result set returned from the
        ///     stored procedure.
        /// </returns>
        DataTable GetTableFromStoredProcedure(
            string storedProcedureName,
            Dictionary<string, object> parameters
        );
    }
}
