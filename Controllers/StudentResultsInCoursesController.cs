using ExamSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Controllers
{
    public class StudentResultsInCoursesController
    {
        public List<StudentResultInCourses> getAllStudentsCoursesResults()
        {
            return Database.studentsResultsInCoursesTable;
        }
    }
}
