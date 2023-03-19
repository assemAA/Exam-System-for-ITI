using ExamSystem.datalayers.Course;
using ExamSystem.datalayers.CoursesInDepartements;
using ExamSystem.datalayers.Departement;
using ExamSystem.datalayers.Exam;
using ExamSystem.datalayers.Instractor;
using ExamSystem.datalayers.Student;
using ExamSystem.datalayers.StudentResultInCourse;
using ExamSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    public sealed class Database
    {
        public static List<Student> studentsTable { get;  private set; }
        public static List<Instractor> instractorsTable { get; private set; }
        public static List<Departement> departementsTable { get; private set; }
        public static List<Course> coursesTable { get; private set; }
        public static List<CoursesInDepartements> crs_deptSTable { get; private set; }
        public static List<Exam> examsTable { get; private set; }

        public static List<StudentResultInCourses> studentsResultsInCoursesTable { get; private set; }
        Database() {
            
            crs_deptSTable = CoursesInDepartementsProcdures.getAllCoursesInDepartements();
            coursesTable = CourseProcdures.getAllCourses();
            departementsTable = DepartementProcdures.getAllDepartements();
            studentsTable = StudentProcdures.getAllStudents();
            examsTable = ExamProcdures.GetExams();
            studentsResultsInCoursesTable = StudentCourseResultsProcdures.getAllStudentsCoursesResults();
            instractorsTable = InstractorProcdures.getAllInstactors();

        }
        private static Database instance = null;
        public static Database Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Database();
                }
                return instance;
            }
        }

        public static void reloadStudentsResultsInCoursesTable()
        {
            studentsResultsInCoursesTable = StudentCourseResultsProcdures.getAllStudentsCoursesResults();
        }

        public static void reloadStudentTable ()
        {
            studentsTable = StudentProcdures.getAllStudents();
        }

        public static void reloadInstractorTable ()
        {
            instractorsTable = InstractorProcdures.getAllInstactors();
        }


    }
}
