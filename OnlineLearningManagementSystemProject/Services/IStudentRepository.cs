using OnlineLearningManagementSystemProject.Models;
using OnlineLearningManagementSystemProject.ViewModel;

namespace OnlineLearningManagementSystemProject.Services
{
    public interface IStudentRepository
    {
        List<Student> GetStudents();
        Student GetStudentById(int id);
        int creatStudent(Student std, IFormFile? Picture);
        int deleteStudent(int id);
        int updateStudent(int id, Student std);
        List<EnrollYearStudentNameViewModel> GetStudentsASEnrollYear();
    }
}
