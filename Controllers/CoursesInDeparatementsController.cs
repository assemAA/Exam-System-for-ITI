using ExamSystem.Models;
using ExamSystem.Reprosatories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Controllers
{
    public  class CoursesInDeparatementsController : ICoursesInDepartements
    {
        public  List<CoursesInDepartements> getAllCoursesInDeparetemnts ()
        {
            List<CoursesInDepartements> crs_depts = Database.crs_deptSTable;
            return crs_depts;

        }
    }
}
