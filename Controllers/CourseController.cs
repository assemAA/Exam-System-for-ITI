using ExamSystem.datalayers.Course;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Controllers
{
    public class CourseController
    {
        public  List<Models.Course> getAllCourses()
        {
            return Database.coursesTable;
        }
    }
}
