using OnlineLearningManagementSystemProject.Models;

namespace OnlineLearningManagementSystemProject.Services
{
    public interface ICoursesRepository
    {
        List<Course> GetCourse();
        Course GetCourseById(int id);
        int creatCourse(Course crs, IFormFile? Picture);
        int deleteCourse(int id);
        int updateCourse(int id, Course crs);
    }
}
