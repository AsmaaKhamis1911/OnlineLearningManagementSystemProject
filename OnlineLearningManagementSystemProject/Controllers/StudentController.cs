using Microsoft.AspNetCore.Mvc;
using OnlineLearningManagementSystemProject.Models;
using OnlineLearningManagementSystemProject.Services;

namespace OnlineLearningManagementSystemProject.Controllers
{
    public class StudentController : Controller
    {
        IStudentRepository stdservice;

        public StudentController(IStudentRepository _stdservice)
        {
            stdservice = _stdservice;
        }

        public IActionResult Index()
        {
            return View(stdservice.GetStudents().ToList());
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(Student std, IFormFile? Picture)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View(std);
            //}
            stdservice.creatStudent(std, Picture);
            return RedirectToAction("Index");

        }
        public IActionResult delete(int id)
        {
            try
            {
                stdservice.deleteStudent(id);

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Exception", ex.InnerException.Message);

            }
            return RedirectToAction("index");
        }
        public IActionResult update(int id)
        {
            return View(stdservice.GetStudentById(id));
        }
        [HttpPost]
        public IActionResult update(int id, Student std)
        {
            stdservice.updateStudent(id, std);
            return RedirectToAction("index");
        }
        public IActionResult getStudentById(int id)
        {
            return View(stdservice.GetStudentById(id));
        }
        public IActionResult GetStudentsASEnrollYear()
        {
            return View(stdservice.GetStudentsASEnrollYear().ToList());
        }
    }
}
