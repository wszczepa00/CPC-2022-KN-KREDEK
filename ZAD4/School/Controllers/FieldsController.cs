using Microsoft.AspNetCore.Mvc;
using School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Controllers
{
    public class FieldsController : Controller
    {

        private readonly DataBaseContext _context;
        public FieldsController(DataBaseContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var fields = _context.Fields.ToList();
            return View(fields);
        }
    }
}
