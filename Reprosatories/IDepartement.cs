using ExamSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Reprosatories
{
    public interface IDepartement
    {
        public List<Departement> getAllDepartements();

        public Departement? GetDepartementById(int? id);
    }
}
