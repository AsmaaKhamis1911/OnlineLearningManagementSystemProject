using OnlineLearningManagementSystemProject.Models;
using OnlineLearningManagementSystemProject.ViewModel;

namespace OnlineLearningManagementSystemProject.Services
{
    public class StaffRepository : IStaffRepository
    {
        LMSContext context;

        public StaffRepository(LMSContext _context)
        {
            context = _context;
        }

        public int creatStaff(Staff sff, IFormFile Picture)
        {
            if (Picture != null && Picture.Length > 0)
            {
                var fileName = Path.GetFileName(Picture.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\staffimage", fileName);
                sff.StaffImage = "~/staffimage/" + fileName;
            }
            context.Staffs.Add(sff);
            int raw = context.SaveChanges();
            return raw;
        }



        public int deleteStaff(int id)
        {
            Staff stf = context.Staffs.FirstOrDefault(s => s.StaffId == id);
            context.Staffs.Remove(stf);
            int raw = context.SaveChanges();
            return raw;
        }

        public List<NationalIDStaffNameViewModel> GetNationalIDStaffNames()
        {
            var staffs = context.Staffs.ToList();
            var NationalIDStaffNamelist = new List<NationalIDStaffNameViewModel>();
            foreach (var staff in staffs)
            {
                NationalIDStaffNamelist.Add(new NationalIDStaffNameViewModel
                {
                    staffid = staff.StaffId,
                    staffname = staff.FirstName + ' ' + staff.LastName,
                    nationalid = staff.NationalID,
                });
            }
            return NationalIDStaffNamelist;
        }

        public List<Staff> GetStaff()
        {
            return context.Staffs.ToList();
        }

        public Staff GetStaffById(int id)
        {
            return context.Staffs.FirstOrDefault(s => s.StaffId == id);
        }

        public int updateStaff(int id, Staff sff)
        {
            Staff oldstf = context.Staffs.FirstOrDefault(s => s.StaffId == id);
            oldstf.FirstName = sff.FirstName;
            oldstf.LastName = sff.LastName;
            oldstf.NationalID = sff.NationalID;
            oldstf.Mobile = sff.Mobile;
            oldstf.Email = sff.Email;
            oldstf.StaffImage = sff.StaffImage;
            int raw = context.SaveChanges();
            return raw;
        }
    }
}
