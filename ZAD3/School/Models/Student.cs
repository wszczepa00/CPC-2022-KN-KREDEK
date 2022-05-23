using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Field { get; set; }
        public string Index { get; set; }
        public Student(int StudentId, string Name, string LastName, string Field, string Index)
        {
            this.StudentId = StudentId;
            this.Name = Name;
            this.LastName = LastName;
            this.Field = Field;
            this.Index = Index;

        }


    }
}
