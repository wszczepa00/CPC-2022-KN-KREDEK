using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public int Ects { get; set; }

        public Course(int CourseId, string Name, int Ects)
        {
            this.CourseId = CourseId;
            this.Name = Name;
            this.Ects = Ects;
        }
    }
}
