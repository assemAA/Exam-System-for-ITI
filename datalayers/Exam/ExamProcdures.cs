using ExamSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ExamSystem.datalayers.Exam
{
    public static class ExamProcdures
    {
        static readonly string connection;
        static SqlConnection sqlConnection;
        static ExamProcdures()
        {
            connection = DatabaseConnection.databaseConnect();
        }

        public static List<Models.Exam> GetExams()
        {
            List<Models.Exam> exams= new List<Models.Exam>();
            #region implement storeds 
            using(sqlConnection = new SqlConnection(connection))
            {
                SqlCommand sqlCommand= new SqlCommand("get_exams" , sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlConnection.Open();

                SqlDataReader dr = sqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    Models.Exam exam = new Models.Exam();
                    exam.id = Convert.ToInt32(dr[0]);
                    exam.name = Convert.ToString(dr[1]);
                    exam.duaration = Convert.ToInt32(dr[2]);
                    exam.no_mcq= Convert.ToInt32(dr[3]);
                    exam.no_tf= Convert.ToInt32(dr[4]);
                    exam.crs_id= Convert.ToInt32(dr[5]);
                    exams.Add(exam);
                }
            }
            #endregion
            return exams;
        }

        public static Tuple<List<FullExamQusetion> , List<ModelAnswer>> generateExamForStudent (string examName)
        {
            List<FullExamQusetion> fullExams = new List<FullExamQusetion>();
            List<ModelAnswer> modelAnswers = new List<ModelAnswer>();

            #region stored procdure 
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                SqlCommand sqlCommand = new SqlCommand("generate_exam_by_student", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@exam_tittle", examName);
                //sqlConnection.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(ds);

                foreach (DataRow dataRow in ds.Tables[0].Rows)
                {
                    FullExamQusetion fullExam = new FullExamQusetion();
                    fullExam.ques_num = Convert.ToInt32(dataRow[0]);
                    fullExam.ques_description = Convert.ToString(dataRow[1]);
                    fullExam.choose_one = Convert.ToString(dataRow[2]);
                    fullExam.choose_two = Convert.ToString(dataRow[3]);
                    fullExam.choose_three = Convert.ToString(dataRow[4]);
                    fullExam.choose_four= Convert.ToString(dataRow[5]);
                    fullExam.mark = Convert.ToInt32((int)dataRow[6]);
                    fullExams.Add(fullExam);
                }
                
                foreach(DataRow dataRow in ds.Tables[1].Rows)
                {
                    ModelAnswer modelAnswer = new ModelAnswer();
                    modelAnswer.exam_id = Convert.ToInt32(dataRow[0]);
                    modelAnswer.ques_num = Convert.ToInt32((int)dataRow[1]);
                    modelAnswer.correct_ans = Convert.ToString(dataRow[2]);
                    modelAnswer.mark = Convert.ToInt32(dataRow[3]);
                    modelAnswers.Add(modelAnswer);
                }
            }
            #endregion

            

            return new Tuple<List<FullExamQusetion>, List<ModelAnswer>> (fullExams , modelAnswers);
        }


        public static void CorrectExam (Models.Student student , Models.Exam exam , DataTable studentAnswers , DataTable modelAnswers)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                SqlCommand sqlCommand = new SqlCommand("correct_exam", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@std_id", student.id);
                sqlCommand.Parameters.AddWithValue("@exam_id", exam.id);
                sqlCommand.Parameters.AddWithValue("@studentAnswers", studentAnswers);
                sqlCommand.Parameters.AddWithValue("@modelAnswers", modelAnswers);

                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlConnection.Open();
                try
                {
                    sqlCommand.ExecuteNonQuery();
                }
                catch
                {
                    
                }
                
            }
        }
    }
}
