using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "CourseName")]
        public string Name { get; set; }
        [Required]
        public int Ects { get; set; }

        public ICollection<Grade> Grades { get; set; }
    }
}
