using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Controllers
{
    public class GradesController : Controller
    {
        private readonly DataBaseContext _context;

        public GradesController(DataBaseContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var grades = _context.Grades.Include(m => m.Student).Include(m => m.Course).ToList();
            return View(grades);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Grade grade)
        {
            _context.Grades.Add(grade);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int Id)
        {
            var grade = _context.Grades.FirstOrDefault(m => m.Id.Equals(Id));
            if (grade == null)
            {
                return NotFound();
            }
            return View(grade);
        }
        [HttpPost]
        public IActionResult Edit(Grade grade)
        {
            if (ModelState.IsValid)
            {
                _context.Grades.Update(grade);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(grade);

        }

        public IActionResult Delete(int Id)
        {
            var grade = _context.Grades.Include(m => m.Student).Include(m => m.Course).FirstOrDefault(m => m.Id.Equals(Id));
            if (grade == null)
            {
                return NotFound();
            }
            return View(grade);
        }
        [HttpPost]
        public IActionResult Delete(Grade grade)
        {
            _context.Grades.Remove(grade);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
