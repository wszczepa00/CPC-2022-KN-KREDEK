using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models
{
    public class Grade
    {

        public int GradeId { get; set; }
        [Required]
        public int StudentId { get; set; }
        [Required]
        public int CourseId { get; set; }
        [Required]
        public double Mark { get; set; }
        public Grade(int GradeId, int StudentId, int CourseId, double Mark)
        {
            this.GradeId = GradeId;
            this.StudentId = StudentId;
            this.CourseId = CourseId;
            this.Mark = Mark;

        }
        public Grade() { }

    }

}
