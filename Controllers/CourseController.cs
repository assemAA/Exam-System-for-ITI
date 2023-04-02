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
        Database database;

        public CourseController()
        {
            database = Database.Instance;
        }
        public  List<Models.Course> getAllCourses()
        {
            return database.coursesTable;
        }
    }
}
