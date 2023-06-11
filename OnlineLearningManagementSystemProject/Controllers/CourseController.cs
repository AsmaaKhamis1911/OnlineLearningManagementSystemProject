using Microsoft.AspNetCore.Mvc;
using OnlineLearningManagementSystemProject.Models;
using OnlineLearningManagementSystemProject.Services;

namespace OnlineLearningManagementSystemProject.Controllers
{
    public class CourseController : Controller
    {
        ICoursesRepository crservice;

        public CourseController(ICoursesRepository _crservice)
        {
            crservice = _crservice;
        }

        public IActionResult Index()
        {
            return View(crservice.GetCourse().ToList());
        }
        public IActionResult add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult add(Course crs, IFormFile? Picture)
        {
            crservice.creatCourse(crs, Picture);
            return RedirectToAction("Index");
        }
        public IActionResult update(int id)
        {
            return View(crservice.GetCourseById(id));
        }
        [HttpPost]
        public IActionResult update(int id, Course crs)
        {
            crservice.updateCourse(id, crs);
            return RedirectToAction("Index");
        }
        public IActionResult delete(int id)
        {
            try
            {
                crservice.deleteCourse(id);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Exception", ex.InnerException.Message);
            }
            return RedirectToAction("index");
        }
    }
}
