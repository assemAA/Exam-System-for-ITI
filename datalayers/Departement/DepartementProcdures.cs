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
    public static class DepartementProcdures
    {
        static readonly string connection;
        
        static DepartementProcdures()
        {
            connection = DatabaseConnection.databaseConnect();
        }
        public static List<Models.Departement> getAllDepartements()
        {
            List<Models.Departement> departements = new List<Models.Departement>();

            #region implement stored
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                SqlCommand sqlCommand = new SqlCommand("getAllDepartements", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlConnection.Open();
                SqlDataReader dr = sqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    Models.Departement departement = new Models.Departement();
                    // complete here 
                    departement.id = Convert.ToInt32(dr[0]);
                    departement.name = Convert.ToString(dr[1]);
                    departement.description = Convert.ToString(dr[2]);
                    departement.location = Convert.ToString(dr[3]);
                    departement.manger_id = Convert.ToInt32(dr[4]);
                    departement.manger_hiredate = Convert.ToDateTime((dr[5]));
                    departements.Add(departement);
                }

            }
            #endregion

            loadCoursesInDepartements(departements);
           
            return departements;

        }

        public static Models.Departement GetDepartementByID(int? id )
        {
            Models.Departement dept = new Models.Departement();
            # region implement stored 
            using (SqlConnection sqlConnection = new SqlConnection( connection ))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "get_dept_by_Id" ;
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@id", id);
                
                sqlConnection.Open();
                SqlDataReader sqlDataReader  =  sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    dept.id = sqlDataReader.GetInt32(0);
                    dept.name = sqlDataReader.GetString(1);
                    dept.description = sqlDataReader.GetString(2);
                    dept.location = sqlDataReader.GetString(3);
                    dept.manger_id= sqlDataReader.GetInt32(4);
                    dept.manger_hiredate = sqlDataReader.GetDateTime(5);
                }
                
            }

            #endregion
            return dept;
        } 

        private static void loadCoursesInDepartements(List<Models.Departement> departements)
        {
           foreach (Models.Departement departement in departements)
            {
                #region implement join 
                List<Models.CoursesInDepartements> crs_depts = Database.crs_deptSTable;
                List<Models.Course> courses = Database.coursesTable;

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
