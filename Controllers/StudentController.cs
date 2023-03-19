using ExamSystem.datalayers.Student;
using ExamSystem.Models;
using ExamSystem.Reprosatories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Controllers
{
    public  class StudentController : IStudent
    {
        public  Student Login(string name, string password)
        {
            Student student = new Models.Student();
            List<Student> students = Database.studentsTable;
            student = students.FirstOrDefault(std => std.name == name && std.password == password);
            return student;
        }

        public IEnumerable<Object>  getResultsInCourses (Student student)
        {
            List<StudentResultInCourses> studentsResultsInCourses = Database.studentsResultsInCoursesTable;
            List<Course> studentCourses = student.courses;

            IEnumerable<Object> studentResults = (from std_res_crs in studentsResultsInCourses
                                 where std_res_crs.std_id == student.id
                                 join std_crs in studentCourses
                                 on std_res_crs.crs_id equals std_crs.Id
                                 select new { Course = std_crs.Name, Degree = std_res_crs.grade , Status = 
                                 std_res_crs.grade >= 50 ? 'P' : 'F'}).ToList();

            return studentResults;
        }

        public void updatePassword (Student student)
        {
            
            int rowEffected = StudentProcdures.updateStudent(student);

            if (rowEffected > 0) MessageBox.Show("Password Updated Successfly");

            Database.reloadStudentTable();
        }
    }
}
