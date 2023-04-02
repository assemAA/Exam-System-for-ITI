using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamSystem.Models;

namespace ExamSystem.Reprosatories
{
    public interface IInstractor
    {
        public Instractor? Login(string name, string password);
        public void addexam(string crs_name, string exam_title, int dur, int n_mcq, int n_tf);
        public void addMcq(string ques_description, string crs_name, string choose_one, string choose_two, string choose_three, string choose_four, string correct_choice,
            int correct_num, int mark);

        public void addTF(string ques_desc, string crs_name, string correct_ans, int mark);

        public List<QuestionsMcq> getMcq();
        public List<Questions_TF> getTf();

        public void updateExam(Models.Exam exam);

        public void updateMcq(Models.QuestionsMcq Mcq);

        public void update_Tf(Models.Questions_TF TF);

        public void deleteTF(int id);
        public void deleteExam(int id);

        public void deleteMcq(int id);
    }
}
