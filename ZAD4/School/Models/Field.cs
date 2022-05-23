using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models
{
    public class Field
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "FieldName")]
        public string Name { get; set; }
        [Required]
        public string Department { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
