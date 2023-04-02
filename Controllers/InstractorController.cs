using ExamSystem.datalayers.Instractor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamSystem.Models;
using ExamSystem.Reprosatories;

namespace ExamSystem.Controllers
{
    public class InstractorController : IInstractor
    {
        
        Database database;
        public InstractorController() { 
            
            database = Database.Instance;
        }
        public  Instractor? Login(string name , string password)
        {
            Instractor instarctor = new Instractor();
            List<Instractor> instractors = database.instractorsTable;
            instarctor = instractors.FirstOrDefault(ins => ins.name == name && ins.password == password);
            return instarctor;
        }
        public void addexam(string crs_name, string exam_title, int dur, int n_mcq, int n_tf)
        {
            InstractorProcdures.addExam(crs_name, exam_title, dur, n_mcq, n_tf);
            database.reloadExamTable();
        }
        public void addMcq(string ques_description, string crs_name, string choose_one, string choose_two, string choose_three, string choose_four, string correct_choice,
            int correct_num, int mark)
        {
            InstractorProcdures.addMcq(ques_description, crs_name, choose_one, choose_two, choose_three, choose_four, correct_choice,
             correct_num, mark);
        }
        public void addTF(string ques_desc, string crs_name, string correct_ans, int mark)
        {
            InstractorProcdures.addTF(ques_desc, crs_name, correct_ans, mark);
        }

        public List<QuestionsMcq> getMcq()
        {
            return InstractorProcdures.getAllMcq();
        }

        public List<Questions_TF> getTf()
        {
            return InstractorProcdures.getAllTF();
        }

        public void updateExam(Models.Exam exam)
        {
            InstractorProcdures.updateExam(exam);
            database.reloadExamTable();
        }
        public void updateMcq(Models.QuestionsMcq Mcq)

        {
            InstractorProcdures.updateMcq(Mcq);
            database.reloadQuestionsMcqTable();
            
        }
         public void update_Tf(Models.Questions_TF TF)

        {
            InstractorProcdures.update_Tf(TF);
            database.reloadQuestions_TFTable();
        }


        public void deleteTF(int id) 
        {
            InstractorProcdures.deleteTF(id);
            database.reloadQuestions_TFTable();
        }
        public void deleteExam(int id)
        {
            InstractorProcdures.deleteExam(id);
            database.reloadExamTable();
        }
        public  void deleteMcq(int id)
        {
            InstractorProcdures.deleteMcq(id);
            database.reloadQuestionsMcqTable();
        }


    }
}
