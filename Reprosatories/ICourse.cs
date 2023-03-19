using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Reprosatories
{
    public interface ICourse
    {
        public List<Models.Course> getAllCourses();
    }
}
