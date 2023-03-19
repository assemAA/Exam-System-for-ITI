using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamSystem.Models;

namespace ExamSystem.Reprosatories
{
    public interface IInstractor
    {
        public Instractor? Login(string name, string password);
    }
}
