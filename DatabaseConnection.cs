using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    public sealed  class DatabaseConnection
    {
        
        readonly string connectionString ;
        DatabaseConnection() { 

            connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString();
        }

        private static DatabaseConnection instance;

        public static DatabaseConnection GetInstance()
        {
            if (instance == null)
            {
                instance = new DatabaseConnection();
            }
            return instance;
        }

        public string databaseConnect ( )
        {
            return connectionString; 
        }
    }
}
