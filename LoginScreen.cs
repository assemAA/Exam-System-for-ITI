using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System;
using ExamSystem.Models;
using ExamSystem.Controllers;

namespace ExamSystem
{
    public partial class LoginScreen : Form
    {
        Database db;
        StudentController studentController;
        InstractorController instractorController;
        public LoginScreen()
        {
            
            InitializeComponent();
            db = Database.Instance;
            studentController = new StudentController();
            instractorController= new InstractorController();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            
            #region student login
            if (rdn_student.Checked)
            {
                Student? student = new Student();
                student = studentController.Login(txt_userName.Text, txt_password.Text);

                if (student != null)
                {
                    StudentScreen studentScreen = new StudentScreen(student);
                    studentScreen.Show();
                    this.Hide();

                }
                else
                    MessageBox.Show("In correct user name or password");

            }
            #endregion

           #region instractor login 
            if (rdn_instractor.Checked) { 
                Instractor instractor= new Instractor();    
                instractor = instractorController.Login(txt_userName.Text , txt_password.Text);

                if (instractor != null)
                    MessageBox.Show("Instactor Login Success");
                else
                    MessageBox.Show("In correct user name or password");
            }
        #endregion

           
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }
    }
}