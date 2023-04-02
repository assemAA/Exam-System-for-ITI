using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ExamSystem.Models;
using ExamSystem.Reprosatories;

namespace ExamSystem.datalayers.Departement
{
    public sealed class DepartementProcdures
    {
        static readonly string connection;
        static readonly Database database;
        static DatabaseConnection dbConnection;
        static DepartementProcdures()
        {
            dbConnection = DatabaseConnection.GetInstance();
            connection = dbConnection.databaseConnect();
            database = Database.Instance;
        }

        
        public static List<Models.Departement> getAllDepartements()
        {
            List<Models.Departement> departements = new List<Models.Departement>();

            #region implement stored
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                SqlCommand sqlCommand = new SqlCommand("getAllDepartements", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                //sqlConnection.Open();
                //SqlDataReader dr = sqlCommand.ExecuteReader();

                DataSet dataSet = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(dataSet);

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    Models.Departement departement = new Models.Departement();
                    // complete here 
                    departement.id = Convert.ToInt32(row[0]);
                    departement.name = Convert.ToString(row[1]);
                    departement.description = Convert.ToString(row[2]);
                    departement.location = Convert.ToString(row[3]);
                    departement.manger_id = Convert.ToInt32(row[4]);
                    departement.manger_hiredate = Convert.ToDateTime((row[5]));
                    departements.Add(departement);
                }

            }
            #endregion

            loadCoursesInDepartements(departements);
           
            return departements;

        }

       

        private static void loadCoursesInDepartements(List<Models.Departement> departements)
        {
           foreach (Models.Departement departement in departements)
            {
                #region implement join 
                List<Models.CoursesInDepartements> crs_depts = database.crs_deptSTable;
                List<Models.Course> courses = database.coursesTable;

                departement.courses = (from cr_d in crs_depts
                                       join cr in courses
                                        on cr_d.crs_id equals cr.Id
                                       where cr_d.dept_id == departement.id
                                       select cr).Select(cr => new Models.Course()
                                       {
                                           Id = cr.Id
                                       ,
                                           Name = cr.Name,
                                           duaration = cr.duaration
                                       }).ToList();


                #endregion
            }
        }


    }
}
