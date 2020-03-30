using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zadanie3.Models;

namespace Zadanie3.DAL
{
    public interface IDBService
    {
        public IEnumerable<Student> GetStudents();
    }
}
