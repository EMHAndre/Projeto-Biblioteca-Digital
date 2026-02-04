using Library1.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace Library1
{
    public static class GlobalConfig
    {
        public const string PrizesFile = "PrizeModels.csv";
        public const string PeopleFile = "PersonModels.csv";
        public const string TeamsFile = "TeamModels.csv";
        public const string TournamentsFile = "TournamentModels.csv";
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        
        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                // TODO - Create SQL Connector
                // TODO - setup the SQL Connector properly
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }
            if (textFiles)
            {
                // TODO - Create Text Connector
                TextConnector text = new TextConnector();
                Connections.Add((IDataConnection)text);
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
