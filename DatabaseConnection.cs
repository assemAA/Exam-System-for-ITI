using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    public static class DatabaseConnection
    {
        
            
       public  static string databaseConnect ( )
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString();
        }
    }
}
