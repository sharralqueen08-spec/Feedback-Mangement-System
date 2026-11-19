using Microsoft.AspNetCore.Mvc;

namespace MyFirstApp.Controllers
{
    public class FeedbackController : Controller
    {


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Submit(
            string StudentName,
            string StudentId,
            string Month,
            string FacultyBatch,
            string Subject,
            string Punctuality,
            string CourseCoverage,
            string TechnicalSupport,
            string DoubtClearing,
            string ExamsAssignments,
            string BookUtilization,
            string StudentAppraisal,
            string ComputerUptime,
            string Remarks
            )

        {
            ViewBag.Name = StudentName;
            ViewBag.studentid = StudentId;
            ViewBag.month= Month;
            ViewBag.facultybatch = FacultyBatch;
            ViewBag.subject = Subject;
            ViewBag.Punctuality = Punctuality;
            ViewBag.CourseCoverage = CourseCoverage;
            ViewBag.TechnicalSupport = TechnicalSupport;
            ViewBag.DoubtClearing = DoubtClearing;
            ViewBag.ExamsAssignments = ExamsAssignments;
            ViewBag.BookUtilization = BookUtilization;
            ViewBag.StudentAppraisal = StudentAppraisal;
            ViewBag.ComputerUptime = ComputerUptime;
            ViewBag.remarks = Remarks;

             return View("~/Views/Pages/Result.cshtml");
        }
    }
}
