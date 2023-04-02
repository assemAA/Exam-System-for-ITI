using ExamSystem.datalayers.Departement;
using ExamSystem.Models;
using ExamSystem.Reprosatories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Controllers
{
    public  class DepartementController : IDepartement
    {
        Database database;
        public DepartementController ()
        {
            database = Database.Instance;
        }
        public  List<Departement> getAllDepartements ()
        {
            return database.departementsTable;
        }
        public  Departement? GetDepartementById (int? id )
        {
            Departement? departement = new Departement();
            departement = database.departementsTable.FirstOrDefault( d => d.id== id );
            return departement;
        }
    }
}
