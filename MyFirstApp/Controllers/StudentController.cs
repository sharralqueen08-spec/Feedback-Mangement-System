using Microsoft.AspNetCore.Mvc;
using MyFirstApp.Data;
using MyFirstApp.Models;

namespace MyFirstApp.Controllers
{
    public class StudentController : Controller
    {

        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string Studentid, string email)
        {
            var student = _context.Students.FirstOrDefault(s =>
            s.StudentId == Studentid &&
            s.Email == email
          
             );

            if (student == null)
            {
                HttpContext.Session.SetString("StudentId",student.StudentId);
                HttpContext.Session.SetString("StudentEmail", student.Email);
                return RedirectToAction("Index","Feedback");


                ViewBag.Error = "Invalid Data";






                [HttpPost]
        public IActionResult Register(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Add(student);
                _context.SaveChanges();

                return View("Result", student);
            }

            return View(student);
            
        }

    }
}
