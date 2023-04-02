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
   
    public sealed  class InstractorProcdures
    {
        static readonly string connectionString;
        static DatabaseConnection dbConnection;
        

        static InstractorProcdures()
        {
            dbConnection = DatabaseConnection.GetInstance();
            connectionString =  dbConnection.databaseConnect();
        }
     
        public static  List<Models.Instractor> getAllInstactors ()
        {
            List<Models.Instractor> instractors= new List<Models.Instractor>();
            #region implement storeds
            using(SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("GetAllInstractor", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                //sqlConnection.Open ();  
                //SqlDataReader dr = sqlCommand.ExecuteReader();

                DataSet dataSet = new DataSet();
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand))
                {
                    dataAdapter.Fill(dataSet);
                } 

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    Models.Instractor instractor = new Models.Instractor();
                    instractor.id = Convert.ToInt32(row[0]);
                    instractor.name = Convert.ToString(row[1]);
                    instractor.password = Convert.ToString(row[2]);
                    instractor.degree = Convert.ToString(row[3]);
                    instractor.salary = Convert.ToDouble(row[4]);
                    instractor.dept_id = Convert.ToInt32(row[5]);
                    instractors.Add (instractor);

                }
            }
            #endregion

            return instractors;
        }
        
        public static void addExam(string crs_name, string exam_title, int dur, int n_mcq, int n_tf)
        {
            int result = 0;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("generate_exam_by_Instractor", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@exam_tittle", exam_title);
                sqlCommand.Parameters.AddWithValue("@exam_duar", dur);
                sqlCommand.Parameters.AddWithValue("@no_mcq", n_mcq);
                sqlCommand.Parameters.AddWithValue("@no_TF", n_tf);
                sqlCommand.Parameters.AddWithValue("@crs_name", crs_name);

                sqlConnection.Open();
                result = sqlCommand.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Added Successfully");
                }
                else
                {
                    MessageBox.Show("Error");

                }

            }
        }
        public static void addMcq(string ques_description, string crs_name, string choose_one, string choose_two, string choose_three, string choose_four, string correct_choice,
               int correct_num, int mark)
        {
            int result = 0;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("add_mcq", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@ques_description", ques_description);
                sqlCommand.Parameters.AddWithValue("@crs_name", crs_name);
                sqlCommand.Parameters.AddWithValue("@choose_one", choose_one);
                sqlCommand.Parameters.AddWithValue("@choose_two", choose_two);
                sqlCommand.Parameters.AddWithValue("@choose_three", choose_three);
                sqlCommand.Parameters.AddWithValue("@choose_four", choose_four);
                sqlCommand.Parameters.AddWithValue("@correct_choice", correct_choice);
                sqlCommand.Parameters.AddWithValue("@correct_num", correct_num);
                sqlCommand.Parameters.AddWithValue("@mark", mark);



                sqlConnection.Open();
                result = sqlCommand.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Added Successfully");
                }
                else
                {
                    MessageBox.Show("Error");

                }

            }

        }
        public static void addTF(string ques_desc, string crs_name, string correct_ans, int mark)
        {
            int result = 0;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("add_T_f", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@ques_desc", ques_desc);
                sqlCommand.Parameters.AddWithValue("@crs_name", crs_name);
                sqlCommand.Parameters.AddWithValue("@correct_ans", correct_ans);
                sqlCommand.Parameters.AddWithValue("@mark", mark);

                sqlConnection.Open();
                result = sqlCommand.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Added Successfully");
                }
                else
                {
                    MessageBox.Show("Error");

                }

            }

        }

        public static List<Models.QuestionsMcq> getAllMcq()
        {
            List<Models.QuestionsMcq> QuestionsMcqs = new List<Models.QuestionsMcq>();
            #region implement storeds
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("getAllMcq", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                //sqlConnection.Open();
                //SqlDataReader dr = sqlCommand.ExecuteReader();

                DataSet dataSet = new DataSet();
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand))
                {
                    dataAdapter.Fill(dataSet);
                }
                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        Models.QuestionsMcq Mcq = new Models.QuestionsMcq();
                        Mcq.ques_id = Convert.ToInt32(row[0]);
                        Mcq.ques_description = Convert.ToString(row[1]);
                        Mcq.crs_id = Convert.ToInt32(row[2]);
                        Mcq.choose_one = Convert.ToString(row[3]);
                        Mcq.choose_two = Convert.ToString(row[4]);
                        Mcq.choose_three = Convert.ToString(row[5]);
                        Mcq.choose_four = Convert.ToString(row[6]);
                        Mcq.correct_choice = Convert.ToString(row[7]);
                        Mcq.correct_num = Convert.ToInt32(row[8]);
                        Mcq.mark = Convert.ToInt32(row[9]);




                        QuestionsMcqs.Add(Mcq);

                    }
            }
            #endregion

            return QuestionsMcqs;
        }

        public static  List<Models.Questions_TF> getAllTF()
        {
            List<Models.Questions_TF> QuestionsTFs = new List<Models.Questions_TF>();
            #region implement storeds
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("getAllTF", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                // sqlConnection.Open();
                // SqlDataReader dr = sqlCommand.ExecuteReader();
                DataSet dataSet = new DataSet();
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand))
                {
                    dataAdapter.Fill(dataSet);
                }
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    Models.Questions_TF TF = new Models.Questions_TF();
                    TF.ques_id = Convert.ToInt32(row[0]);
                    TF.ques_desc = Convert.ToString(row[1]);
                    TF.crs_id = Convert.ToInt32(row[2]);
                    TF.correct_ans = Convert.ToString(row[3]);
                    TF.mark = Convert.ToInt32(row[4]);

                    QuestionsTFs.Add(TF);

                }
            }
            #endregion

            return QuestionsTFs;
        }

        public static  void updateMcq(Models.QuestionsMcq Mcq)
        {
            int rowEffected = 0;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("update_mcq", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Q_id", Mcq.ques_id);
                sqlCommand.Parameters.AddWithValue("@ques_description", Mcq.ques_description);
                sqlCommand.Parameters.AddWithValue("@crs_id", Mcq.crs_id);
                sqlCommand.Parameters.AddWithValue("@choose_one", Mcq.choose_one);
                sqlCommand.Parameters.AddWithValue("@choose_two", Mcq.choose_two);
                sqlCommand.Parameters.AddWithValue("@choose_three", Mcq.choose_three);
                sqlCommand.Parameters.AddWithValue("@choose_four", Mcq.choose_four);
                sqlCommand.Parameters.AddWithValue("@correct_choice", Mcq.correct_choice);
                sqlCommand.Parameters.AddWithValue("@correct_num", Mcq.correct_num);
                sqlCommand.Parameters.AddWithValue("@mark", Mcq.mark);


                sqlConnection.Open();

                rowEffected = sqlCommand.ExecuteNonQuery();

                if (rowEffected > 0)
                {
                    MessageBox.Show("Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Error");

                }


            }
            
        }

        public static void update_Tf(Models.Questions_TF TF)
        {
            int rowEffected = 0;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("update_Tf", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Q_id", TF.ques_id);
                sqlCommand.Parameters.AddWithValue("@ques_desc", TF.ques_desc);
                sqlCommand.Parameters.AddWithValue("@crs_id", TF.crs_id);
                sqlCommand.Parameters.AddWithValue("@correct_ans", TF.correct_ans);
                sqlCommand.Parameters.AddWithValue("@mark", TF.mark);


                sqlConnection.Open();

                rowEffected = sqlCommand.ExecuteNonQuery();


                if (rowEffected > 0)
                {
                    MessageBox.Show("Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Error");

                }
            }
         
        }
     
        public static  void updateExam(Models.Exam exam)
        {
            int rowEffected = 0;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("update_exam", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@exam_id", exam.id);
                sqlCommand.Parameters.AddWithValue("@exam_name", exam.name);
                sqlCommand.Parameters.AddWithValue("@exam_duar", exam.duaration);
                sqlCommand.Parameters.AddWithValue("@no_mcq", exam.no_mcq);
                sqlCommand.Parameters.AddWithValue("@no_TF", exam.no_tf);
                sqlCommand.Parameters.AddWithValue("@crs_id", exam.crs_id);
                

                sqlConnection.Open();

                rowEffected = sqlCommand.ExecuteNonQuery();

                if (rowEffected > 0)
                {
                    MessageBox.Show("Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Error");

                }


            }
            
        }
        public static  void deleteExam(int id)
        {
            int rowEffected = 0;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("delete_exam", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@exam_id", id);

                sqlConnection.Open();

                rowEffected = sqlCommand.ExecuteNonQuery();


                if (rowEffected > 0)
                {
                    MessageBox.Show("Deleted Successfully");
                }
                else
                {
                    MessageBox.Show("Error");

                }
            }
            
        }
        public static void deleteMcq(int id)
        {
            int rowEffected = 0;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("delete_Qmcq", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Q_id", id);

                sqlConnection.Open();

                rowEffected = sqlCommand.ExecuteNonQuery();


                if (rowEffected > 0)
                {
                    MessageBox.Show("Deleted Successfully");
                }
                else
                {
                    MessageBox.Show("Error");

                }
            }

        }
        public static void deleteTF(int id)
        {
            int rowEffected = 0;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("delete_Qtf", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Q_id", id);

                sqlConnection.Open();

                rowEffected = sqlCommand.ExecuteNonQuery();


                if (rowEffected > 0)
                {
                    MessageBox.Show("Deleted Successfully");
                }
                else
                {
                    MessageBox.Show("Error");

                }
            }

        }



    }
}
