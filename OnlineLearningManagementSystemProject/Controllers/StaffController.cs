using Microsoft.AspNetCore.Mvc;
using OnlineLearningManagementSystemProject.Models;
using OnlineLearningManagementSystemProject.Services;

namespace OnlineLearningManagementSystemProject.Controllers
{
    public class StaffController : Controller
    {
        IStaffRepository stfservice;

        public StaffController(IStaffRepository _stfservice)
        {
            stfservice = _stfservice;
        }

        public IActionResult Index()
        {
            return View(stfservice.GetStaff().ToList());
        }
        public IActionResult GetstaffById(int id)
        {
            return View(stfservice.GetStaffById(id));
        }
        public IActionResult add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult add(Staff sff, IFormFile Picture)
        {
            stfservice.creatStaff(sff, Picture);
            return RedirectToAction("Index");
        }
        public IActionResult update(int id)
        {
            return View(stfservice.GetStaffById(id));
        }
        [HttpPost]
        public IActionResult update(int id, Staff stf)
        {
            stfservice.updateStaff(id, stf);
            return RedirectToAction("Index");
        }
        public IActionResult GetStaffASNationaliId()
        {
            return View(stfservice.GetNationalIDStaffNames().ToList());
        }
    }
}
