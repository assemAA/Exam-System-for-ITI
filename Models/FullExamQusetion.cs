using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Models
{
    public class FullExamQusetion
    {
        public int ques_num { get; set; }
        public string ques_description { get; set; }
        public string choose_one { get; set; }
        public string choose_two { get; set; }
        public string? choose_three { get; set; }
        public string? choose_four { get; set; }

        public int mark { get; set; }   
    }
}
