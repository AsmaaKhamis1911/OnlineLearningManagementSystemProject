using Microsoft.AspNetCore.Mvc;
using OnlineLearningManagementSystemProject.Services;

namespace OnlineLearningManagementSystemProject.Controllers
{
    public class StaffCourseController : Controller
    {
        IStaffCourseRepository servicestaff;

        public StaffCourseController(IStaffCourseRepository _servicestaff)
        {
            servicestaff = _servicestaff;
        }
        public IActionResult GetCoursesStaff(int id)
        {
            return View(servicestaff.GetCoursesStaff(id));
        }
        public IActionResult addcoursetostaff(int id)
        {
            ViewBag.StaffId = id;
            return View(servicestaff.AddCoursesToStaff(id));
        }
        [HttpPost]
        public IActionResult addcoursetostaff(int staffid, int courseId)
        {

            servicestaff.AddCoursesToStaff(staffid, courseId);
            return RedirectToAction("GetCoursesStaff");
        }
        public IActionResult GetCoursesStaffByAdmin(int id)
        {
            ViewBag.StaffId = id;
            return View(servicestaff.GetCoursesStaffByAdmin(id));
        }
        [HttpPost]
        public IActionResult GetCoursesStaffByAdmin(int staffid, int courseId)
        {
            servicestaff.GetCoursesStaffByAdmin(staffid, courseId);
            return RedirectToAction("GetCoursesStaff");
        }
        public IActionResult GetStaffsByCourseId(int Id)
        {
            return View(servicestaff.GetStaffsByCourseId(Id));
        }
    }
}
