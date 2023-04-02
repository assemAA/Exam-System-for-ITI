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
        Database database;
        public CoursesInDeparatementsController()
        {
            database = Database.Instance;
        }
        public  List<CoursesInDepartements> getAllCoursesInDeparetemnts ()
        {
            List<CoursesInDepartements> crs_depts = database.crs_deptSTable;
            return crs_depts;

        }
    }
}
