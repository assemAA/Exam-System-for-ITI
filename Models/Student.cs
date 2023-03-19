using ExamSystem.datalayers.Student;
using ExamSystem.Reprosatories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Models
{
    public  class Student  
    {
        public int id { get; set; }

        public string name { get; set; }

        public string password { get; set; }

        public int? dept_id { get; set; }

        public int? age { get; set; }

        public List<Course> courses { get; set; }
    }
}
