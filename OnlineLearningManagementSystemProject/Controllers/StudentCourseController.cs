using Microsoft.AspNetCore.Mvc;
using OnlineLearningManagementSystemProject.Services;

namespace OnlineLearningManagementSystemProject.Controllers
{
    public class StudentCourseController : Controller
    {
        IStudentCourseRepository studentCourseRepository;

        public StudentCourseController(IStudentCourseRepository _studentCourseRepository)
        {
            studentCourseRepository = _studentCourseRepository;
        }

        public IActionResult Index()
        {
            return View(studentCourseRepository.GetAllStusent().ToList());

        }



        public IActionResult GetCoursesStudent(int id)
        {
            return View(studentCourseRepository.GetCoursesStudent(id));
        }
        public IActionResult addcoursetostudent(int id)
        {
            ViewBag.StudentId = id;
            return View(studentCourseRepository.AddCoursesToStudent(id));
        }
        [HttpPost]
        public IActionResult addcoursetostudent(int stdid, int courseId)
        {
            studentCourseRepository.AddCoursesToStudent(stdid, courseId);
            return RedirectToAction("Index");
        }
        public IActionResult GetCoursesStudentByAdmin(int id)
        {
            ViewBag.StudentId = id;
            return View(studentCourseRepository.GetCoursesStudentByAdmin(id));
        }
        [HttpPost]
        public IActionResult GetCoursesStudentByAdmin(int stdid, int courseId)
        {
            studentCourseRepository.GetCoursesStudentByAdmin(stdid, courseId);
            return RedirectToAction("Index");
        }
        public IActionResult GetStudentsByCourseId(int id)
        {
            return View(studentCourseRepository.GetStudentsByCourseId(id));
        }
    }
}

