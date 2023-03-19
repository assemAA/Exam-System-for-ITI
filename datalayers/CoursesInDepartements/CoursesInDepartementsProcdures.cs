using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ExamSystem.Models;

namespace ExamSystem.datalayers.CoursesInDepartements
{
    public static class CoursesInDepartementsProcdures
    {
        static readonly string connectionString;

        static CoursesInDepartementsProcdures()
        {
            connectionString = DatabaseConnection.databaseConnect();
        }

        public static List<Models.CoursesInDepartements> getAllCoursesInDepartements ()
        {
            List<Models.CoursesInDepartements> crs_deptsList = new List<Models.CoursesInDepartements>();

            #region implement stored
            using(SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("get_all_courses_in_departements", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlConnection.Open();
                SqlDataReader dr = sqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    Models.CoursesInDepartements crs_dept = new Models.CoursesInDepartements();
                    crs_dept.dept_id = Convert.ToInt32(dr[0]);
                    crs_dept.crs_id = Convert.ToInt32(dr[1]);
                    crs_deptsList.Add(crs_dept);
                }
            }
            #endregion

            return crs_deptsList;
        }

    }
}
