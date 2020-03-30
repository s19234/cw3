using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zadanie3.Models;

namespace Zadanie3.DAL
{
    public class MockDBService : IDBService
    {
        private static IEnumerable<Student> _students;

        static MockDBService()
        {
            _students = new List<Student>
            {
                new Student(1, "Jan", "Kowalski"),
                new Student(2, "Anna", "Malewski"),
                new Student(3, "Andrzej", "Andrzejewicz")
            };
        }

        public IEnumerable<Student> GetStudents()
        {
            return _students;
        }
    }
}
