using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Models
{
    public  class Departement
    {
        public int? id { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public string location { get; set; }

        public int? manger_id { get; set; }

        public DateTime manger_hiredate { get; set;}

        public List<Course> courses { get; set; }
    }
}
