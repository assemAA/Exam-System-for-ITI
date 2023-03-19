using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamSystem.Models;
 

namespace ExamSystem.datalayers.Instractor
{
   
    public static class InstractorProcdures
    {
        static readonly string connectionString;
        

        static InstractorProcdures()
        {
            connectionString = DatabaseConnection.databaseConnect();
        }

        public static List<Models.Instractor> getAllInstactors ()
        {
            List<Models.Instractor> instractors= new List<Models.Instractor>();
            #region implement storeds
            using(SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("GetAllInstractor", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlConnection.Open ();  
                SqlDataReader dr = sqlCommand.ExecuteReader();
                while (dr.Read ())
                {
                    Models.Instractor instractor = new Models.Instractor();
                    instractor.id = Convert.ToInt32(dr[0]);
                    instractor.name = Convert.ToString(dr[1]);
                    instractor.password = Convert.ToString(dr[2]);
                    instractor.degree = Convert.ToString(dr[3]);
                    instractor.salary = Convert.ToDouble(dr[4]);
                    instractor.dept_id = Convert.ToInt32(dr[5]);
                    instractors.Add (instractor);

                }
            }
            #endregion

            return instractors;
        }
        public static Models.Instractor? login (string name , string password)
        {
            Models.Instractor? instractor = new Models.Instractor();
            #region implement stored procdeur
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("login_Instractor", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter instractorName = new SqlParameter()
                {
                    ParameterName = "@ins_name",
                    SqlDbType = SqlDbType.VarChar,
                    Value = name,
                    Direction = ParameterDirection.Input,
                };

                SqlParameter instractorPassword = new SqlParameter()
                {
                    ParameterName = "@ins_pass",
                    SqlDbType = SqlDbType.VarChar,
                    Value = password,
                    Direction = ParameterDirection.Input,
                };

                sqlCommand.Parameters.Add(instractorName);
                sqlCommand.Parameters.Add(instractorPassword);

                connection.Open();
                SqlDataReader dr = sqlCommand.ExecuteReader();

                while (dr.Read())
                {

                    instractor.id = Convert.ToInt32(dr[0]);
                    instractor.name = Convert.ToString(dr[1]);
                    instractor.password = Convert.ToString(dr[2]);
                    instractor.degree = Convert.ToString(dr[3]);
                    instractor.salary = Convert.ToDouble(dr[4]);    
                    instractor.dept_id = Convert.ToInt32(dr[5]);    

                }

            }
            #endregion

            return instractor;
        }
    }
}
