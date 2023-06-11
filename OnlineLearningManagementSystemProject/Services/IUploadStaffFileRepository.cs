using Microsoft.AspNetCore.Mvc;
using OnlineLearningManagementSystemProject.Models;

namespace OnlineLearningManagementSystemProject.Services
{
    public interface IUploadStaffFileRepository
    {
        int UploadDocument(IFormFile formFile, [Bind("MaterialName,CourseID,StaffId")] Material material);
        int UploadLink([Bind("MaterialPath")] string materialPath, Material material);
        int UploadVideo(IFormFile formFile, [Bind("MaterialName,CourseID,StaffId")] Material material);
        IEnumerable<Material> GetAll();
        IEnumerable<Material> GetLecturesByMaterial(int corseid);
        IEnumerable<Material> GetLecturesByMaterialDoctor(int corseid, int staffid);
        int DeleteMaterial(int materialId);
    }
}
