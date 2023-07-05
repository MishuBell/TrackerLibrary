using System.Configuration;

namespace TrackerLibrary
{

    /// <summary>
    /// Static class used to store IDataConnector and retrieve Connection String values
    /// </summary>
    public static class GlobalConfig
    {
        /// <summary>
        /// IDataConnector instance property using a private set and public getter
        /// </summary>
        public static IDataConnector Connection { get; private set; }

        /// <summary>
        /// Initializes connections based on the provided DatabaseType. The DatabaseType is a public enum.
        /// </summary>
        /// <param name="databaseType">The type of database to connect to (Sql or TextFile)</param>
        public static void InitializeConnection(DatabaseType databaseType)
        {
            switch (databaseType)
            {
                case DatabaseType.Sql:
                    SqlConnector sql = new SqlConnector();
                    Connection = sql;
                    break;

                case DatabaseType.TextFile:
                    TextConnector text = new TextConnector();
                    Connection = text;
                    break;

                default:
                    break;
            }
        }
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}

/*

1. Because Tim said that we could either use the Windows SQL database or save to a text file, the list Connections was created, to store any number of connections that we might want to use.

2. The InitializeConnections method is used to initialize the connections that we want to use. It will be called at the start of the application. The method is not scalable




*/
