using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Models
{
    public class StudentAnswer
    {
        public int exam_id { get; set; }
        public int student_id { get; set; }
        public int question_num { get; set; }
        public string student_answer { get; set; }

    }
}
