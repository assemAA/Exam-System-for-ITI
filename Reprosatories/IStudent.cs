using ExamSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Reprosatories
{
    public interface IStudent
    {
        public Student Login(string name, string password);
        public IEnumerable<Object> getResultsInCourses(Student student);
        public void updatePassword(Student student);

    }
}
