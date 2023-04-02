using ExamSystem.datalayers.Course;
using ExamSystem.datalayers.CoursesInDepartements;
using ExamSystem.datalayers.Departement;
using ExamSystem.datalayers.Exam;
using ExamSystem.datalayers.InsCourse;
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
        public  List<Student> studentsTable { get;  private set; }
        public  List<Instractor> instractorsTable { get; private set; }
        public  List<Departement> departementsTable { get; private set; }
        public  List<Course> coursesTable { get; private set; }
        public  List<CoursesInDepartements> crs_deptSTable { get; private set; }
        public  List<Exam> examsTable { get; private set; }
        
        public  List<insCourse> Ins_courseTable { get;  set; }
        public  List<QuestionsMcq> QuestionsMcqTable { get; set; }
        public  List<Questions_TF> Questions_TFTable { get; set; }



        public  List<StudentResultInCourses> studentsResultsInCoursesTable { get; private set; }
 
        Database() {

            crs_deptSTable = CoursesInDepartementsProcdures.getAllCoursesInDepartements();
            coursesTable = CourseProcdures.getAllCourses();
            departementsTable = DepartementProcdures.getAllDepartements();
            studentsTable = StudentProcdures.getAllStudents();
            examsTable = ExamProcdures.GetExams();
            Ins_courseTable = InsCourseProcdures.getAllInsCourse();
            studentsResultsInCoursesTable = StudentCourseResultsProcdures.getAllStudentsCoursesResults();
            instractorsTable = InstractorProcdures.getAllInstactors();
            QuestionsMcqTable=InstractorProcdures.getAllMcq();
            Questions_TFTable=InstractorProcdures.getAllTF();
        }
        private static Database instance = null;
        public static  Database Instance
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



        public  void reloadStudentsResultsInCoursesTable()
        {
            studentsResultsInCoursesTable = StudentCourseResultsProcdures.getAllStudentsCoursesResults();
        }

        public  void reloadStudentTable ()
        {
            studentsTable = StudentProcdures.getAllStudents();
        }

        public  void reloadInstractorTable ()
        {
            instractorsTable = InstractorProcdures.getAllInstactors();
        }
        public  void reloadInstractorCourseTable()
        {
            Ins_courseTable = InsCourseProcdures.getAllInsCourse();
        }

        public  void reloadQuestionsMcqTable()
        {
            QuestionsMcqTable = InstractorProcdures.getAllMcq();
        }

        public  void reloadQuestions_TFTable()
        {
            Questions_TFTable = InstractorProcdures.getAllTF();
        }

        public  void reloadExamTable()
        {
            examsTable = ExamProcdures.GetExams();

        }



    }
}
