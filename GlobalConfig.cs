using System.Collections.Generic;

namespace TrackerLibrary
{
    /// <summary>
    /// This holds the list of IDataConnector instances that will be used by the application to connect to the database or text files. 
    /// </summary>
    public static class GlobalConfig
    {
        /// <summary>
        /// List of connections to be used by the application. This list will hold any class that implements the IDataConnector interface.
        /// </summary>
        public static List<IDataConnector> Connections { get; private set; } = new List<IDataConnector>();

        /// <summary>
        /// Initializes any desired connections for the application, using provided booleans to determine which types of connections to initialize.
        /// </summary>
        /// <param name="useDatabase">Whether or not to initialize the database connection.</param>
        /// <param name="useTextFiles">Whether or not to initialize the text file connection.</param>
        public static void InitializeConnections(bool useDatabase, bool useTextFiles)
        {
            if (useDatabase)
            {
                // TODO - Setup the SQL connector properly
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }

            if (useTextFiles)
            {
                // TODO - Setup the Text File connector properly
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }
    }
}

/*

1. Because Tim said that we could either use the Windows SQL database or save to a text file, the list Connections was created, to store any number of connections that we might want to use.

2. The InitializeConnections method is used to initialize the connections that we want to use. It will be called at the start of the application. The method is not scalable




*/
