﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Models
{
    public class StudentResultInCourses
    {
        public int std_id { get; set; }
        public int crs_id { get; set; }

        public int grade { get; set; }
    }
}
