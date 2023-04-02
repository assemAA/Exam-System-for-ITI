using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Models
{
    public class Questions_TF
    {
        public int ques_id { get; set; }
        public string ques_desc { get; set; }
        public int crs_id { get; set; }
        public string correct_ans { get; set; }
        public int mark { get; set; }
    }
}
