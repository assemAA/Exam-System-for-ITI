using ExamSystem.datalayers.Instractor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamSystem.Models;
using ExamSystem.Reprosatories;

namespace ExamSystem.Controllers
{
    public class InstractorController : IInstractor
    {
        public  Instractor? Login(string name , string password)
        {
            Instractor instarctor = new Instractor();
            List<Instractor> instractors = Database.instractorsTable;
            instarctor = instractors.FirstOrDefault(ins => ins.name == name && ins.password == password);
            return instarctor;
        }
    }
}
