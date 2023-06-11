using OnlineLearningManagementSystemProject.Models;
using OnlineLearningManagementSystemProject.ViewModel;

namespace OnlineLearningManagementSystemProject.Services
{
    public interface IStudentCourseRepository
    {
        List<CourseListViewModel> GetAllStusent();
        List<CourseViewModel> GetCoursesStudent(int stdid);
        List<StudentCourseViewModel1> AddCoursesToStudent(int stdid);
        int AddCoursesToStudent(int stdid, int courseId);
        List<StudentCourseViewModel1> GetCoursesStudentByAdmin(int stdid);
        int GetCoursesStudentByAdmin(int stdid, int courseId);

        List<Student> GetStudentsByCourseId(int courseId);
    }
}
