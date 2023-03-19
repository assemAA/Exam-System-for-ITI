using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Models
{
    public class ModelAnswer
    {
        public int exam_id { get; set; }    
        public int ques_num { get; set; }
        public string correct_ans { get; set; }
        public int mark { get; set; }
    }
}
