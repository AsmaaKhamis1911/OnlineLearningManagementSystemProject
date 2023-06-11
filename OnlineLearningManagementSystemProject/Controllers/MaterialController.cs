using Microsoft.AspNetCore.Mvc;
using OnlineLearningManagementSystemProject.Models;
using OnlineLearningManagementSystemProject.Services;

namespace OnlineLearningManagementSystemProject.Controllers
{
    public class MaterialController : Controller
    {

        IUploadStaffFileRepository uploadStaffFileServise;

        public MaterialController(IUploadStaffFileRepository _uploadStaffFileServise)
        {
            uploadStaffFileServise = _uploadStaffFileServise;
        }

        public IActionResult Index()
        {
            var model = uploadStaffFileServise.GetAll();
            return View(model);
        }
        [HttpGet]
        [Route("Material/CreateD/{courseId:int}/{staffId:int}")]
        public IActionResult CreateD(int courseId, int staffId)
        {
            ViewBag.CourseId = courseId;
            ViewBag.StaffId = staffId;
            ViewBag.MaterialTypes = Enum.GetNames(typeof(MaterialType)).ToList();
            return View();
        }
        [HttpPost]
        public IActionResult CreateDocument(Material model)
        {

            uploadStaffFileServise.UploadDocument(model.formFile, model);
            return RedirectToAction("Index");
        }



        [HttpGet]
        [Route("Material/CreateV/{courseId:int}/{staffId:int}")]
        public IActionResult CreateV(int courseId, int staffId)
        {
            ViewBag.CourseId = courseId;
            ViewBag.StaffId = staffId;
            ViewBag.MaterialTypes = Enum.GetNames(typeof(MaterialType)).ToList();
            return View();
        }
        [HttpPost]
        public IActionResult CreateVideo(Material model)
        {

            uploadStaffFileServise.UploadVideo(model.formFile, model);
            return RedirectToAction("Index");
        }




        [HttpGet]
        [Route("Material/CreateL/{courseId:int}/{staffId:int}")]
        public IActionResult CreateL(int courseId, int staffId)
        {
            ViewBag.CourseId = courseId;
            ViewBag.StaffId = staffId;
            ViewBag.MaterialTypes = Enum.GetNames(typeof(MaterialType)).ToList();
            return View();
        }
        [HttpPost]
        public IActionResult CreateLink(Material model)
        {

            uploadStaffFileServise.UploadLink(model.MaterialPath, model);
            return RedirectToAction("Index");
        }

        public IActionResult GetLecturesByMaterial(int id)
        {
            var Lectures = uploadStaffFileServise.GetLecturesByMaterial(id);
            ViewBag.CourseID = id;
            return View(Lectures);
        }

        [Route("Material/GetLecturesByMaterialDoctor/{courseId:int}/{staffId:int}")]
        public IActionResult GetLecturesByMaterialDoctor(int courseId, int staffId)
        {
            var Lectures = uploadStaffFileServise.GetLecturesByMaterialDoctor(courseId, staffId);
            ViewBag.CourseID = courseId;
            ViewBag.StaffId = staffId;
            return View(Lectures);
        }
        public IActionResult Delete(int materialId)
        {
            uploadStaffFileServise.DeleteMaterial(materialId);
            return RedirectToAction("Index");
        }
    }
}
