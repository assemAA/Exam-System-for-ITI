using System;
using ExamSystem.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.datalayers.Student
{
    public sealed class StudentProcdures
    {
         static readonly string connectionString ;
         static SqlConnection connection;
         static readonly Database database;
         static DatabaseConnection dbConnection;
        static StudentProcdures ()
        {
            dbConnection = DatabaseConnection.GetInstance();
            connectionString = dbConnection.databaseConnect();
            database = Database.Instance;
        }


        public static List<Models.Student> getAllStudents()
        {
            List<Models.Student> students = new List<Models.Student> () ;

            #region implement stored
            using(SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("getstudents", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                //sqlConnection.Open();
                //SqlDataReader dr = sqlCommand.ExecuteReader();
                DataSet dataSet = new DataSet();
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand)) 
                {
                    dataAdapter.Fill(dataSet);
                }

                foreach(DataRow row in dataSet.Tables[0].Rows)
                {
                    Models.Student student = new Models.Student();
                    student.id = Convert.ToInt32(row[0]);
                    student.name = Convert.ToString(row[1]);
                    student.password = Convert.ToString(row[2]);
                    student.dept_id = Convert.ToInt32(row[3]);
                    student.age= Convert.ToInt32(row[4]);
                    students.Add(student);
                }
            }



            loadStudentCourses(students);
            #endregion

            return students;
        }
        

        private static void loadStudentCourses (List<Models.Student> students)
        {
            List<Models.Departement> departements = new List<Models.Departement>();
            departements = database.departementsTable;
            foreach (Models.Student std in students)
            {
                std.courses = departements.FirstOrDefault(d => d.id == std.dept_id).courses.ToList();
            }
        }

        public static  int updateStudent (Models.Student student)
        {
            int rowEffected = 0;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString)) 
            {
                SqlCommand sqlCommand = new SqlCommand("UpdateStudent", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", student.id);
                sqlCommand.Parameters.AddWithValue("@name" , student.name);
                sqlCommand.Parameters.AddWithValue("@pass", student.password);
                sqlCommand.Parameters.AddWithValue("@age", student.age);

                sqlConnection.Open();

                rowEffected = sqlCommand.ExecuteNonQuery();

            
            }
            return rowEffected;
        }


    }
}
