using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamSystem.Models;


namespace ExamSystem.datalayers.InsCourse
{
    public sealed class InsCourseProcdures
    {
        static readonly string connectionString;
        static DatabaseConnection dbConnection;
        static InsCourseProcdures() 
        {
            dbConnection = DatabaseConnection.GetInstance();
            connectionString = dbConnection.databaseConnect();
        }

        public static List<Models.insCourse> getAllInsCourse()
        {
            List<Models.insCourse> insCourses = new List<Models.insCourse>();
            #region implement storeds
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("getAllIns_Course", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                // sqlConnection.Open();
                //SqlDataReader dr = sqlCommand.ExecuteReader();

                DataSet ds = new DataSet();
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand))
                {
                    dataAdapter.Fill(ds);
                }
               
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    Models.insCourse insCrs = new Models.insCourse();
                    insCrs.Ins_id = Convert.ToInt32(row[0]);
                    insCrs.crs_id = Convert.ToInt32(row[1]);
                    insCrs.Evaluation = Convert.ToString(row[2]);

                    insCourses.Add(insCrs);

                }
            }
            #endregion

            return insCourses;
        }
    }


}
