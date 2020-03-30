using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Zadanie3.Models;
using Zadanie3.DAL;

namespace Zadanie3.Controllers
{
    [Route("api/students")]
    [ApiController]

    public class StudentsController : ControllerBase
    {
        private List<Student> list = new List<Student>();
        private readonly IDBService _dbService;

        public StudentsController(IDBService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet]
        public IActionResult GetStudents(string orderBy)
        {
            return Ok(_dbService.GetStudents());
        }

        /// <summary>
        /// Metoda do zwracania studenta
        /// </summary>
        /// <param name="id">Id studenta</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            if (id == 1)
                return Ok("Kowalski");
            else if (id == 2)
                return Ok("Malewski");
            else if (id == 3)
                return Ok("Andrzejewski");
            return NotFound("Student not found");
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            student.IndexNumber = $"s{new Random().Next(1, 20000)}";
            list.Add(student);
            return Ok(student);
        }

        [HttpDelete]
        public IActionResult DeleteStudent(int index)
        {
            foreach(Student student in list)
            {
                if (student.CompareTo(index) == 0)
                {
                    list.Remove(student);
                    return Ok("Student removed");
                }
            }
            return NotFound("Student not found");
        }

        [HttpPut]
        public IActionResult ActStudent(int index)
        {
            foreach(Student student in list)
            {
                if(student.CompareTo(index) == 0)
                {
                    return Ok("Student act");
                }
            }
            return NotFound("Student not found");
        }

        
    }
}