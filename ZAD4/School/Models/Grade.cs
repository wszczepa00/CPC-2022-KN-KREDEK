using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models
{
    public class Grade
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int StudentId { get; set; }
        [ForeignKey("StudentId")]
        public Student Student { get; set; }
        [Required]
        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        public Course Course { get; set; }
        [Required]
        public float Mark { get; set; }

    }
}
