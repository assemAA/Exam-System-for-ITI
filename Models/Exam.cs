using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Models
{
    public class Exam
    {
        public int id { get; set; }

        public string? name { get; set; }

        public int? duaration { get; set; }

        public int? no_mcq { get; set; }

        public int? no_tf { get; set; }

        public int? crs_id { get; set; }
    }
}
