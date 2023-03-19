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
    public partial class changePasswordScreen : Form
    {
        StudentController studentController;
        Student student;
        public changePasswordScreen(Student student)
        {
            InitializeComponent();
            studentController = new StudentController();
            this.student = student;
        }

        private void changePasswordScreen_Load(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string password = txt_pass.Text;
            string comfirmPassword = txt_comfirmPass.Text;

            if (password != comfirmPassword) MessageBox.Show("Please check password and it's comfiramtion");
            else
            {
                student.password = password;
                studentController.updatePassword(student);
                this.Close();
            }
        }
    }
}
