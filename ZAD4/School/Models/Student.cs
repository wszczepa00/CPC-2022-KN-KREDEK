using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        public int FieldId { get; set; }
        [ForeignKey("FieldId")]
        public Field Field { get; set; }
        [Required]
        [StringLength(6)]
        public string Index { get; set; }

        public ICollection<Grade> Grades { get; set; }
    }
}
