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
    public partial class StudentScreen : Form
    {
        readonly Student  student;
        readonly List<Exam> exams;
        readonly List<Departement> departements;
        readonly ExamController examController;
        readonly DepartementController departementController;
        readonly LoginScreen loginScreen;
        readonly StudentController studentController;

        public StudentScreen(Student student)
        {
            InitializeComponent();

            examController = new ExamController();
            studentController = new StudentController();
            departementController= new DepartementController();

            this.student = student;
            exams = examController.getAllExams();
            departements = departementController.getAllDepartements();
            loginScreen = new LoginScreen();
           
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }


        private void StudentScreen_Load(object sender, EventArgs e)
        {
            loadPersonalInfo();
            loadCourses();
            loadResults();
        }

        private void loadPersonalInfo()
        {
            lbl_name.Text = this.student.name;
            lbl_age.Text = this.student.age.ToString();

            lbl_dept.Text = loadDepartement(this.student.dept_id).name.ToString();
        }
        private Models.Departement? loadDepartement(int? id)
        {
            return departementController.GetDepartementById(id);
        }

        private void loadCourses ()
        {
            
            IEnumerable<Course> courses = departements.Where(d => d.id == student.dept_id).Select(d => d.courses).ToList()[0];

          
            cmb_courses.DataSource = courses.ToList();
            cmb_courses.DisplayMember = "Name";
            cmb_courses.ValueMember = "Id";
            cmb_courses.SelectedIndex = 0;
        }

        private void cmb_courses_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_exams.SelectedIndex= -1;
            IEnumerable<Exam> selectedExams;
            try
            {
                int choicenCourse = (int)cmb_courses.SelectedValue;
                selectedExams = exams.Where(ex => ex.crs_id == Convert.ToInt32(choicenCourse)).ToList();
                cmb_exams.DataSource = selectedExams;
                cmb_exams.DisplayMember = "name";
                cmb_exams.ValueMember = "id";
            }
            catch (Exception ex)
            {
                Course choicenCourse = (Course)cmb_courses.SelectedValue;
                selectedExams = exams.Where(ex => ex.crs_id == Convert.ToInt32(choicenCourse.Id)).ToList();
                cmb_exams.DataSource = selectedExams;
                cmb_exams.DisplayMember = "name";
                cmb_exams.ValueMember = "id";
            }
            
            
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            int? examId = (int?)cmb_exams.SelectedValue;
            

            if (examId != null)
            {
                Exam choicenExam = examController.getExamById(examId);
                FinalExamScreen finalExamScreen = new FinalExamScreen(this.student, choicenExam);
                finalExamScreen.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Select The exam tittle");
            }

        }

        private void loadResults()
        {
            dgv_results.DataSource = studentController.getResultsInCourses(this.student);

            dgv_results.Columns[0].Width = 370;
            dgv_results.Columns[1].Width = 300;
            dgv_results.Columns[2].Width = 300;


        }

        private void btn_changepassword_Click(object sender, EventArgs e)
        {
            changePasswordScreen changePasswordScreen = new changePasswordScreen(student);
            changePasswordScreen.Show();
        }

        private void btn_signOut_Click(object sender, EventArgs e)
        {
            
            loginScreen.Show();
            this.Close();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}

