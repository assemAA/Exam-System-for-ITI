using ExamSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Reprosatories
{
    public interface IExam
    {
        public List<Models.Exam> getAllExams();

        public Exam getExamById(int? id);

        public Tuple<List<FullExamQusetion>, List<ModelAnswer>> generateExamForStudent(string examName);

        public void correctExam(Models.Student student, Models.Exam exam, DataTable studentAnswers, DataTable modelAnswers);
    }
}
