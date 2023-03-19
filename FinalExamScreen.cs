using ExamSystem.Controllers;
using ExamSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamSystem
{
    public partial class FinalExamScreen : Form
    {
        Student student;
        Exam exam;
        List<FullExamQusetion> fullExamQusetions;
        List<ModelAnswer> modelAnswers;
        ExamController examController;
        int questionIndex = 0;
        List<RadioButton> radioButtons;
        List<StudentAnswer> studentAnswers;

        int duaration;
        int minutes;
        int seconds;    
        public FinalExamScreen(Student student , Exam exam)
        {
            InitializeComponent();
            this.student = student;
            this.exam = exam;
            examController = new ExamController();
            radioButtons = new List<RadioButton>() { rdn_chOne , rdn_chTwo , rdn_chThree , rdn_chFour};
            studentAnswers = new List<StudentAnswer>();

            duaration = exam.duaration ?? 0;
            minutes = duaration - 1;
            seconds = 59 ;

            timer.Start();

        }

        private void FinalExamScreen_Load(object sender, EventArgs e)
        {
           
            loadExam();
            displayQuestion();
            displayForwardBackwordButtons();
            loadStudentAnswers();
            ShowHideSubmit(false);
            dgv_ans.Visible = false;
        }

        private void loadExam()
        {
            Tuple<List<FullExamQusetion>, List<ModelAnswer>> examAndAnswers = examController.generateExamForStudent(exam.name);
            this.fullExamQusetions = examAndAnswers.Item1;
            this.modelAnswers= examAndAnswers.Item2;
            
        }

        private void displayQuestion()
        {
        
            if (this.questionIndex >= 0 && this.questionIndex < this.fullExamQusetions.Count)
            {
                lbl_tittle.Text = this.exam.name.ToString();
                FullExamQusetion question = this.fullExamQusetions.ElementAt(this.questionIndex);
                lbl_question.Text = (questionIndex+1).ToString() + "-" + question.ques_description.ToString();
                rdn_chOne.Text = question.choose_one.ToString();
                rdn_chTwo.Text = question.choose_two.ToString();
                if (question.choose_three == null || question.choose_three == "")
                {
                    rdn_chThree.Visible = false;
                    rdn_chFour.Visible = false;
                }
                else
                {
                    rdn_chThree.Visible= true;
                    rdn_chFour.Visible= true;
                    rdn_chThree.Text = question.choose_three.ToString();
                    rdn_chFour.Text = question.choose_four.ToString();
                }
            }

            checkQuestionAnswerdOrNot();
        }

        private void checkQuestionAnswerdOrNot ()
        {
            StudentAnswer studentAnswer = new StudentAnswer();
            studentAnswer = studentAnswers.FirstOrDefault( sd=> sd.question_num == this.questionIndex+1);
            if (studentAnswer != null) checkChoosenChoice(studentAnswer);
            else uncheckALlChoices();
        }


        private void ShowHideSubmit (bool show)
        {
            btn_submit.Visible = show;
        }

        private void uncheckALlChoices ()
        {
            foreach(RadioButton rd in radioButtons)
                rd.Checked = false;
        }

        private void checkChoosenChoice(StudentAnswer studentAnswer)
        {
           
            RadioButton rd = radioButtons.FirstOrDefault(r => r.Text == studentAnswer.student_answer) ;
            rd.Checked = true;

        }



        private void increamentQuestionIndex ()
        {
            if (questionIndex < fullExamQusetions.Count - 1)
                questionIndex++;
            displayForwardBackwordButtons();
        }

        private void decreamentQuestionIndex()
        {
            if (questionIndex > 0)
                questionIndex--;
            displayForwardBackwordButtons();
        }

        private void displayForwardBackwordButtons()
        {
            if (questionIndex == fullExamQusetions.Count - 1)
            {
                btn_back.Visible = true;
                btn_next.Visible = false;
                ShowHideSubmit(true);
            }
            else if (questionIndex == 0)
            {
                btn_back.Visible = false;
                btn_next.Visible = true;
            }
            else
            {
                btn_back.Visible = true;
                btn_next.Visible = true;
            }
        }
        private void btn_next_Click(object sender, EventArgs e)
        {
            increamentQuestionIndex();
            displayQuestion();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            decreamentQuestionIndex();
            displayQuestion();
        }

        private void loadStudentAnswers ()
        {
            dgv_ans.DataSource = studentAnswers.ToList();
        }

        private void rdn_chOne_CheckedChanged(object sender, EventArgs e)
        {
            updateStudentAnswer(rdn_chOne);
            loadStudentAnswers();
        }

        private void rdn_chTwo_CheckedChanged(object sender, EventArgs e)
        {

            updateStudentAnswer(rdn_chTwo);

            loadStudentAnswers();
        }


        private void rdn_chThree_CheckedChanged(object sender, EventArgs e)
        {
            updateStudentAnswer(rdn_chThree);
            loadStudentAnswers();
        }

        private void rdn_chFour_CheckedChanged(object sender, EventArgs e)
        {
            updateStudentAnswer(rdn_chFour);
            loadStudentAnswers();
        }
        private void updateStudentAnswer (RadioButton rd)
        {
            StudentAnswer studentAnswer;
            studentAnswer = this.studentAnswers.FirstOrDefault(q => q.question_num == questionIndex + 1);

            if (studentAnswer == null)
            {
                studentAnswer = new StudentAnswer();
                studentAnswer.exam_id = exam.id;
                studentAnswer.student_id = this.student.id;
                studentAnswer.question_num = questionIndex + 1;
                studentAnswer.student_answer = rd.Text;
                studentAnswers.Add(studentAnswer);
            }
            else
            {
                studentAnswer.exam_id = exam.id;
                studentAnswer.student_id = this.student.id;
                studentAnswer.question_num = questionIndex + 1;
                studentAnswer.student_answer = rd.Text;
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            submitExam();
        }

        private void submitExam ()
        {
            try
            {
                DataTable studentAnswersTable = generateStudentAnswersTable();
                DataTable modelAnswersTable = generateModelAnswerTable();
                examController.correctExam(student, exam, studentAnswersTable, modelAnswersTable);
                MessageBox.Show("Exam Corrected and saved successfly");
               

            }
            catch
            {
                MessageBox.Show("there is a problem while correcting your answers");
            }
            finally
            {
                StudentScreen studentScreen = new StudentScreen(student);
                studentScreen.Show();
                this.Close();
            }
        }

        private DataTable generateStudentAnswersTable ()
        {
            DataTable studentAnswersTable = new DataTable();

            DataColumn column = new DataColumn();
            column.ColumnName = "exam_id";
            column.DataType = typeof(int);
            studentAnswersTable.Columns.Add(column);

            column = new DataColumn();
            column.ColumnName = "std_id";
            column.DataType = typeof(int);
            studentAnswersTable.Columns.Add(column);

            column = new DataColumn();
            column.ColumnName = "ques_num";
            column.DataType = typeof(int);
            studentAnswersTable.Columns.Add(column);

            column = new DataColumn();
            column.ColumnName = "std_ans";
            column.DataType = typeof(string);
            studentAnswersTable.Columns.Add(column);


            foreach(StudentAnswer std_ans in studentAnswers)
            {
                DataRow dataRow = studentAnswersTable.NewRow();
                dataRow[0] = std_ans.exam_id;
                dataRow[1] = std_ans.student_id;
                dataRow[2] = std_ans.question_num;
                dataRow[3] = std_ans.student_answer;
                studentAnswersTable.Rows.Add(dataRow);
            }

            return studentAnswersTable;
        }

        private DataTable generateModelAnswerTable ()
        {
            DataTable modelAnswersTable = new DataTable();

            DataColumn column = new DataColumn();
            column.ColumnName = "exam_id";
            column.DataType = typeof(int);
            modelAnswersTable.Columns.Add(column);

            column = new DataColumn();
            column.ColumnName = "ques_num";
            column.DataType = typeof(int);
            modelAnswersTable.Columns.Add(column);

            column = new DataColumn();
            column.ColumnName = "correct_ans";
            column.DataType = typeof(string);
            modelAnswersTable.Columns.Add(column);

            column = new DataColumn();
            column.ColumnName = "mark";
            column.DataType = typeof(int);
            modelAnswersTable.Columns.Add(column);

            foreach (ModelAnswer mod_ans in modelAnswers) 
            {
                DataRow dataRow = modelAnswersTable.NewRow();
                dataRow[0] = mod_ans.exam_id;
                dataRow[1] = mod_ans.ques_num;
                dataRow[2] = mod_ans.correct_ans;
                dataRow[3] = mod_ans.mark;
                modelAnswersTable.Rows.Add(dataRow);
            }

            return modelAnswersTable;
        }

        private void dgv_ans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            seconds-- ;
            if (seconds == 0 && minutes == 0  )
            {
                timer.Stop();
                submitExam();

               
            }
            else if ( seconds == 0)
            {
                minutes--;
                seconds = 59;
            }

            lbl_time.Text = $"{minutes} : {seconds}";
                

        }
    }
}
