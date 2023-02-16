using System.Collections.Generic;
using System.Data;

using StarWars.Data.DataAccess;

namespace StarWars.Tests.Data
{
    internal class DALStub : IDAL
    {
        public DataTable testTable;
        public object testValue;

        public void ExecuteStoredProcedure(
            string storedProcedureName,
            Dictionary<string, object> parameters
        )
        { }

        public object GetValueFromStoredProcedure(
            string storedProcedureName,
            Dictionary<string, object> parameters
        )
        {
            return testValue;
        }

        public DataTable GetTableFromStoredProcedure(
            string storedProcedureName,
            Dictionary<string, object> parameters
        )
        {
            return testTable;
        }
    }
}
