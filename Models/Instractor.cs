using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Models
{
    public class Instractor
    {
        public int? id { get; set; } 

        public string? name { get; set; }

        public string? password { get; set; }

        public string? degree { get; set; }

        public double? salary { get; set; }
        public int? dept_id { get; set; }

        public List<Course>? courses { get; set; }

    }
}
