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
    public static class StudentProcdures
    {
        static readonly string connectionString ;
        static SqlConnection connection;
        static StudentProcdures ()
        {
            connectionString = DatabaseConnection.databaseConnect();
        }

        public static List<Models.Student> getAllStudents()
        {
            List<Models.Student> students = new List<Models.Student> () ;

            #region implement stored
            using(SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("getstudents", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlConnection.Open();
                SqlDataReader dr = sqlCommand.ExecuteReader();
                while(dr.Read())
                {
                    Models.Student student = new Models.Student();
                    student.id = Convert.ToInt32(dr[0]);
                    student.name = Convert.ToString(dr[1]);
                    student.password = Convert.ToString(dr[2]);
                    student.dept_id = Convert.ToInt32(dr[3]);
                    student.age= Convert.ToInt32(dr[4]);
                    students.Add(student);
                }
            }



            loadStudentCourses(students);
            #endregion

            return students;
        }
        public static Models.Student? implementStudentLogin ( string name , string password)
        {
            Models.Student student = new Models.Student ();

            #region implement stored procdure 
            using (connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("login_Student", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter studentName = new SqlParameter()
                {
                    ParameterName = "@std_name",
                    SqlDbType = SqlDbType.VarChar,
                    Value = name,
                    Direction = ParameterDirection.Input,
                };

                SqlParameter studentPassword = new SqlParameter()
                {
                    ParameterName = "@std_pass",
                    SqlDbType = SqlDbType.VarChar,
                    Value = password,
                    Direction = ParameterDirection.Input,
                };

                sqlCommand.Parameters.Add(studentName);
                sqlCommand.Parameters.Add(studentPassword);

                connection.Open();
                SqlDataReader dr = sqlCommand.ExecuteReader();

                while (dr.Read())
                {
                    
                    student.id = Convert.ToInt32(dr[0]);
                    student.name = Convert.ToString(dr[1]);
                    student.password = Convert.ToString(dr[2]);
                    student.dept_id = Convert.ToInt32(dr[3]);
                    student.age = Convert.ToInt32(dr[4]);
                    
                }

            }

            #endregion

            return student;


        }

        private static void loadStudentCourses (List<Models.Student> students)
        {
            List<Models.Departement> departements = new List<Models.Departement>();
            departements = Database.departementsTable;
            foreach (Models.Student std in students)
            {
                std.courses = departements.FirstOrDefault(d => d.id == std.dept_id).courses.ToList();
            }
        }

        public static int updateStudent (Models.Student student)
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
