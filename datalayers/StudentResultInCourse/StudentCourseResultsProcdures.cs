using ExamSystem.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ExamSystem.datalayers.StudentResultInCourse
{
    public static class StudentCourseResultsProcdures
    {
        static readonly string connectionString ;

        static StudentCourseResultsProcdures()
        {
            connectionString = DatabaseConnection.databaseConnect();
        }

        public static List<StudentResultInCourses> getAllStudentsCoursesResults()
        {
            List<StudentResultInCourses> studentsResultsInCourses = new List<StudentResultInCourses>();
            #region implement stored procdures
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("getAllStudentsCoursesResults", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                
                DataSet ds = new DataSet();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(ds);

                foreach (DataRow dataRow in ds.Tables[0].Rows)
                {
                    StudentResultInCourses studentResultInCourses = new StudentResultInCourses();
                    studentResultInCourses.std_id = Convert.ToInt32(dataRow[0]);
                    studentResultInCourses.crs_id = Convert.ToInt32(dataRow[1]);
                    studentResultInCourses.grade= Convert.ToInt32(dataRow[2]);
                    studentsResultsInCourses.Add(studentResultInCourses);

                }

            }
            #endregion

            return studentsResultsInCourses;
        }

    }
}
