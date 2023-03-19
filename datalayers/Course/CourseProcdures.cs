using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ExamSystem.Models;
namespace ExamSystem.datalayers.Course
{
    public static class CourseProcdures
    {
        static readonly string connection;
        static SqlConnection sqlConnection;

        static CourseProcdures()
        {
            connection = DatabaseConnection.databaseConnect();
        }

        public static List<Models.Course>? getAllCourses()
        {
            List<Models.Course> courses = new List<Models.Course>();
            
            #region implement stored procdure 
            using (sqlConnection = new SqlConnection(connection))
            {
                SqlCommand sqlCommand = new SqlCommand("getAllCourses", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
               // sqlConnection.Open();

                SqlDataAdapter dr = new SqlDataAdapter(sqlCommand);
                DataSet ds = new DataSet();
                dr.Fill(ds);

                foreach(DataRow dataRow in ds.Tables[0].Rows)
                {
                    Models.Course course = new Models.Course();
                    course.Id = Convert.ToInt32(dataRow["crs_Id"]);
                    course.Name = Convert.ToString(dataRow["crs_name"]);
                    course.duaration = Convert.ToInt32(dataRow["crs_duaration"]);
                    courses.Add(course);
                }
                

            }
            #endregion
            return courses;
        }
    }
}
