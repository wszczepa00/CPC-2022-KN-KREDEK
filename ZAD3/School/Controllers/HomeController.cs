using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using School.Models;
using School.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace School.Controllers
{
    public class HomeController : Controller
    {
        private CourseRepository courseRepository;
        private StudentRepository studentRepository;
        private GradeRepository gradeRepository;
        public HomeController(IConfiguration config)
        {
            courseRepository = new CourseRepository(config);
            studentRepository = new StudentRepository(config);
            gradeRepository = new GradeRepository(config);
        }

        public IActionResult AllCourses()
        {
            var courses = courseRepository.GetCourses();
            return View(courses);
        }
        public IActionResult AllStudents()
        {
            var students = studentRepository.GetStudents();
            return View(students);
        }
        public IActionResult AllGrades()
        {
            var grades = gradeRepository.GetGrades();
            return View(grades);
        }

        public IActionResult AddGrade()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult AddGrade([Bind("StudentId,CourseId,Mark")] Grade grade)
        {
            if (ModelState.IsValid)
            {

                gradeRepository.InsertGrade(grade);
                ModelState.Clear();
                return View("AddGrade");
            }
            else
            {
                return View(grade);
            }
        }

        public IActionResult UpdateGrade(int Id)
        {
            var grades = gradeRepository.GetGrades();
            var updatingGrade = grades.FirstOrDefault(x => x.GradeId == Id);
            return View(updatingGrade);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult UpdateGrade([Bind("StudentId,CourseId,Mark")] Grade grade)
        {

            if (ModelState.IsValid)
            {
                gradeRepository.UpdateGrade(grade);
                return View(grade);
            }
            else
            {
                return View(grade);
            }
        }
        public IActionResult GradeDetails(int Id)
        {
            var grades = gradeRepository.GetGrades();
            var students = studentRepository.GetStudents();
            var courses = courseRepository.GetCourses();
            var grade = grades.FirstOrDefault(x => x.GradeId == Id);
            var student = students.FirstOrDefault(x => x.StudentId == grade.StudentId);
            var course = courses.FirstOrDefault(x => x.CourseId == grade.CourseId);
            ViewBag.student = student;
            ViewBag.course = course;
            return View(grade);
        }
        public IActionResult DeleteGrade(int Id)
        {

            var grades = gradeRepository.GetGrades();
            var students = studentRepository.GetStudents();
            var courses = courseRepository.GetCourses();
            var grade = grades.FirstOrDefault(x => x.GradeId == Id);
            var student = students.FirstOrDefault(x => x.StudentId == grade.StudentId);
            var course = courses.FirstOrDefault(x => x.CourseId == grade.CourseId);
            gradeRepository.DeleteGrade(Id);
            ViewBag.student = student;
            ViewBag.course = course;
            return View(grade);
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
