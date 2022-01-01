using System.Collections.Generic;
using TrackerLibrary.DataAccess;
using System.Configuration;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnections (DatabaseType db)
        {
            if(db == DatabaseType.Sql)
            {
                // TODO - create SQL connection
                SqlConnector sql = new SqlConnector();
                Connection = sql;

            }
            else if(db == DatabaseType.TextFile)
            {
                // TODO - crate text files
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
