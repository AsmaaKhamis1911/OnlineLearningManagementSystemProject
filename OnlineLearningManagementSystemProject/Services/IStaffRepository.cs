using OnlineLearningManagementSystemProject.Models;
using OnlineLearningManagementSystemProject.ViewModel;

namespace OnlineLearningManagementSystemProject.Services
{
    public interface IStaffRepository
    {
        List<Staff> GetStaff();
        Staff GetStaffById(int id);
        int creatStaff(Staff sff, IFormFile Picture);
        int deleteStaff(int id);
        int updateStaff(int id, Staff sff);
        List<NationalIDStaffNameViewModel> GetNationalIDStaffNames();
    }
}
