using Microsoft.AspNetCore.Mvc;
using School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Controllers
{
    public class CoursesController : Controller
    {

        private readonly DataBaseContext _context;
        public CoursesController(DataBaseContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var courses = _context.Courses.ToList();
            return View(courses);
        }
    }
}
