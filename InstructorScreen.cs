using ExamSystem.Controllers;
using ExamSystem.datalayers.InsCourse;
using ExamSystem.datalayers.Instractor;
using ExamSystem.Models;
using ExamSystem.Reprosatories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ExamSystem
{
    public partial class InstructorScreen : Form
    {
        Database db;
        readonly Instractor instractor ;
        readonly List<insCourse> insCourses;
        readonly List<Course> Courses;
        readonly LoginScreen loginScreen;
        

        InstractorController instractorController;
        
        CourseController CourseController;
        ExamController examController;
        public InstructorScreen(Instractor instractor)
        {
            InitializeComponent();
            db = Database.Instance;
            
            instractorController = new InstractorController();
            this.instractor = instractor;
            CourseController= new CourseController();
            examController= new ExamController();

            loginScreen = new LoginScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            instractorController.addexam(comboBox1.Text, textBox2.Text, int.Parse(textBox3.Text), int.Parse(textBox4.Text), int.Parse(textBox5.Text));
            inst_examTable();
            clean();

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void InstructorScreen_Load(object sender, EventArgs e)
        {

            List<insCourse> list = InsCourseProcdures.getAllInsCourse();
            List<int> Crs_id = list.Where(c=>c.Ins_id==instractor.id).Select(c => c.crs_id).ToList();
            List<Course> crs = CourseController.getAllCourses();
            List<Course> c = crs.Where(c => Crs_id.Contains(c.Id)).ToList();


            comboBox1.DataSource = c;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";

            comboBox2.DataSource = c;
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Id";

            comboBox3.DataSource = c;
            comboBox3.DisplayMember = "Name";
            comboBox3.ValueMember = "Id";

            inst_examTable();
            inst_mcqTable();
            inst_tfTable();



        }

        private void button2_Click(object sender, EventArgs e)
        {
           instractorController.addMcq(txt_ques_mcq.Text, comboBox2.Text, txt_choose1.Text, txt_choose2.Text,
               txt_choose3.Text, txt_choose4.Text, txt_mcq_correct.Text, int.Parse(txt_mcq_correct_num.Text), int.Parse(txt_mark.Text));
            inst_mcqTable();
            clean();


        }

        private void button3_Click(object sender, EventArgs e)
        {
           instractorController.addTF(txt_ques_tf.Text,comboBox3.Text, txt_tf_correct.Text, int.Parse(txt_tf_mark.Text));
            inst_tfTable();
            clean();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void txt_choose1_TextChanged(object sender, EventArgs e)
        {

        }
        private int id;
        private int mcq_id;
        private int tf_id;

        private void exam_DGV_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            id = (int)exam_DGV.SelectedRows[0].Cells[0].Value;
            textBox2.Text = exam_DGV.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = exam_DGV.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = exam_DGV.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = exam_DGV.SelectedRows[0].Cells[4].Value.ToString();
            comboBox1.SelectedValue = (int)exam_DGV.SelectedRows[0].Cells[5].Value;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Exam Update_exam=new Exam();
            Update_exam.id = id;
            Update_exam.name = textBox2.Text;
            Update_exam.crs_id = int.Parse(comboBox1.SelectedValue.ToString());
            Update_exam.duaration = int.Parse(textBox3.Text);
            Update_exam.no_mcq = int.Parse(textBox4.Text);
            Update_exam.no_tf = int.Parse(textBox5.Text);
            instractorController.updateExam(Update_exam);
            inst_examTable();
            clean();

        }

        private void mcq_update_Click(object sender, EventArgs e)
        {
            QuestionsMcq Update_mcq = new QuestionsMcq();
            Update_mcq.ques_id = mcq_id;
            Update_mcq.ques_description = txt_ques_mcq.Text ;
            Update_mcq.crs_id = int.Parse(comboBox2.SelectedValue.ToString());
            Update_mcq.choose_one = txt_choose1.Text;
            Update_mcq.choose_two= txt_choose2.Text;
            Update_mcq.choose_three = txt_choose3.Text;
            Update_mcq.choose_four = txt_choose4.Text;
            Update_mcq.correct_choice = txt_mcq_correct.Text;
            Update_mcq.correct_num = int.Parse(txt_mcq_correct_num.Text);
            Update_mcq.mark = int.Parse(txt_mark.Text);

            instractorController.updateMcq(Update_mcq);
            inst_mcqTable();
            clean();

        }

        private void Mcq_DGV_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            mcq_id = (int)Mcq_DGV.SelectedRows[0].Cells[0].Value;
            txt_ques_mcq.Text = Mcq_DGV.SelectedRows[0].Cells[1].Value.ToString();
            comboBox2.SelectedValue = (int)Mcq_DGV.SelectedRows[0].Cells[2].Value;
            txt_choose1.Text = Mcq_DGV.SelectedRows[0].Cells[3].Value.ToString();
            txt_choose2.Text = Mcq_DGV.SelectedRows[0].Cells[4].Value.ToString();
            txt_choose3.Text = Mcq_DGV.SelectedRows[0].Cells[5].Value.ToString();
            txt_choose4.Text = Mcq_DGV.SelectedRows[0].Cells[6].Value.ToString();
            txt_mcq_correct.Text = Mcq_DGV.SelectedRows[0].Cells[7].Value.ToString();
            txt_mcq_correct_num.Text = Mcq_DGV.SelectedRows[0].Cells[8].Value.ToString();
            txt_mark.Text = Mcq_DGV.SelectedRows[0].Cells[8].Value.ToString();


        }

        private void TF_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TF_DGV_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tf_id = (int)TF_DGV.SelectedRows[0].Cells[0].Value;
            txt_ques_tf.Text = TF_DGV.SelectedRows[0].Cells[1].Value.ToString();
            comboBox3.SelectedValue = (int)TF_DGV.SelectedRows[0].Cells[2].Value;
            txt_tf_correct.Text = TF_DGV.SelectedRows[0].Cells[3].Value.ToString();
            txt_tf_mark.Text = TF_DGV.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void tf_update_Click(object sender, EventArgs e)
        {
            Questions_TF Update_tf = new Questions_TF();
            Update_tf.ques_id = tf_id;
            Update_tf.ques_desc = txt_ques_tf.Text;
            Update_tf.crs_id = int.Parse(comboBox3.SelectedValue.ToString());
            Update_tf.correct_ans = txt_tf_correct.Text;
            Update_tf.mark = int.Parse(txt_tf_mark.Text);

            instractorController.update_Tf(Update_tf);
            inst_tfTable();
            clean();



        }
        private void inst_examTable()
        {
            List<Exam> Exams = examController.getAllExams();
            List<insCourse> list = InsCourseProcdures.getAllInsCourse();
            List<int> Crs_id = list.Where(c => c.Ins_id == instractor.id).Select(c => c.crs_id).ToList();
            List<Exam> ins_exam = Exams.Where(e => Crs_id.Contains(e.crs_id)).ToList();
            exam_DGV.DataSource = ins_exam;
            exam_DGV.Columns[0].Visible = false;

        }
        private void inst_mcqTable()
        {
            List<insCourse> list = InsCourseProcdures.getAllInsCourse();
            List<int> Crs_id = list.Where(c => c.Ins_id == instractor.id).Select(c => c.crs_id).ToList();
            List<QuestionsMcq> mcqs = instractorController.getMcq();
            List<QuestionsMcq> ins_mcq = mcqs.Where(e => Crs_id.Contains(e.crs_id)).ToList();
            Mcq_DGV.DataSource = ins_mcq;
            Mcq_DGV.Columns[0].Visible = false;

        }
        private void inst_tfTable()
        {
            List<insCourse> list = InsCourseProcdures.getAllInsCourse();
            List<int> Crs_id = list.Where(c => c.Ins_id == instractor.id).Select(c => c.crs_id).ToList();
            List<Questions_TF> TF = instractorController.getTf();
            List<Questions_TF> ins_tf = TF.Where(e => Crs_id.Contains(e.crs_id)).ToList();

            TF_DGV.DataSource = ins_tf;
            TF_DGV.Columns[0].Visible = false;
        }

        private void exam_delete_Click(object sender, EventArgs e)
        {
            instractorController.deleteExam(id);
            inst_examTable();
            clean();

        }

        private void mcq_delet_Click(object sender, EventArgs e)
        {
            instractorController.deleteMcq(mcq_id);
            inst_mcqTable();
            clean();

        }

        private void tf_delete_Click(object sender, EventArgs e)
        {
            instractorController.deleteTF(tf_id);
            inst_tfTable();
            clean();
        }

        private void clean()
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            txt_choose1.Text = "";
            txt_choose2.Text = "";
            txt_choose3.Text = "";
            txt_choose4.Text = "";
            txt_mark.Text = "";
            txt_mcq_correct.Text = "";
            txt_mcq_correct_num.Text = "";
            txt_ques_mcq.Text = "";
            txt_ques_tf.Text = "";
            txt_tf_correct.Text = "";
            txt_tf_mark.Text = "";
            comboBox1.SelectedIndex= 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;


        }
    }
}
