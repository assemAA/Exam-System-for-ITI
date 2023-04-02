using ExamSystem.datalayers.Exam;
using ExamSystem.Models;
using ExamSystem.Reprosatories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Controllers
{
    public  class ExamController : IExam
    {
       

        Database database;

        
        public ExamController()
        {
           
            database = Database.Instance;
        }
        public List<Models.Exam> getAllExams ()
        {
            return database.examsTable;
        }

        public Exam getExamById (int? id)
        {
            Exam exam = database.examsTable.FirstOrDefault( ex => ex.id == id);
            return exam; 
        }

        public Tuple<List<FullExamQusetion>, List<ModelAnswer>> generateExamForStudent(string examName ,Student student)
        {
            return ExamProcdures.generateExamForStudent(examName , student);
        }

        public void correctExam (Models.Student student, Models.Exam exam, DataTable studentAnswers, DataTable modelAnswers)
        {
            ExamProcdures.CorrectExam(student, exam, studentAnswers, modelAnswers);
            database.reloadStudentsResultsInCoursesTable();
        }
    }
}
