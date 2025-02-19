using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Organization
{
    [Serializable]
    public class Student
    {
        public Student() { }
        public string? Name { get; set; } = string.Empty;
        public string? CareerId { get; set; } = string.Empty;
        public string? Career { get; set; } = string.Empty;
        public int? Semester { get; set; }
    }
}
