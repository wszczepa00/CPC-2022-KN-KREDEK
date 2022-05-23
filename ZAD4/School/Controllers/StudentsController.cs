using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Controllers
{
    public class StudentsController : Controller
    {
        private readonly DataBaseContext _context;

        public StudentsController(DataBaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Students.Include(m => m.Field).ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));

        }

        public IActionResult Delete(int Id)
        {
            var student = _context.Students.Include(m => m.Field).Include(m => m.Grades).FirstOrDefault(m => m.Id.Equals(Id));
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }
        [HttpPost]
        public IActionResult Delete(Student student)
        {
            var gradesToDelete = _context.Grades.Where(m => m.Student.Equals(student));
            _context.Grades.RemoveRange(gradesToDelete);
            _context.Students.Remove(student);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
