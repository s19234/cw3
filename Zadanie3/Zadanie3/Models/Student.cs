using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zadanie3.Models
{
    public class Student : IComparable
    {
        public int IdStudent { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IndexNumber { get; set; }

        public int CompareTo(object obj)
        {
            Student student = obj as Student;
            return this.IdStudent - student.IdStudent;
        }
    }
}
