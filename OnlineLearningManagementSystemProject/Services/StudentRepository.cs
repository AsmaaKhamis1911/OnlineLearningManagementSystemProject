using OnlineLearningManagementSystemProject.Models;
using OnlineLearningManagementSystemProject.ViewModel;

namespace OnlineLearningManagementSystemProject.Services
{
    public class StudentRepository : IStudentRepository
    {
        LMSContext context;

        public StudentRepository(LMSContext _context)
        {
            context = _context;
        }

        public int creatStudent(Student std, IFormFile? Picture)
        {
            if (Picture != null && Picture.Length > 0)
            {
                var fileName = Path.GetFileName(Picture.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\studentimage", fileName);
                std.StudentPicture = "~/studentimage/" + fileName;
            }
            context.Students.Add(std);
            int raw = context.SaveChanges();
            return raw;
        }

        public int deleteStudent(int id)
        {
            Student student = context.Students.FirstOrDefault(s => s.StudentID == id);
            context.Students.Remove(student);
            int raw = context.SaveChanges();
            return raw;
        }

        public Student GetStudentById(int id)
        {
            return context.Students.FirstOrDefault(s => s.StudentID == id);
        }



        public List<Student> GetStudents()
        {
            return context.Students.ToList();
        }

        public int updateStudent(int id, Student student)
        {
            Student oldstd = context.Students.FirstOrDefault(s => s.StudentID == id);
            oldstd.FirstName = student.FirstName;
            oldstd.LastName = student.LastName;
            oldstd.Email = student.Email;
            oldstd.EnrollYear = student.EnrollYear;
            oldstd.Mobile = student.Mobile;
            oldstd.NationalID = student.NationalID;
            oldstd.UniversityID = student.UniversityID;
            int raw = context.SaveChanges();
            return raw;
        }
        public List<EnrollYearStudentNameViewModel> GetStudentsASEnrollYear()
        {
            var students = context.Students.ToList();
            var enrollYearStudentNameList = new List<EnrollYearStudentNameViewModel>();
            foreach (var student in students)
            {
                enrollYearStudentNameList.Add(new EnrollYearStudentNameViewModel
                {
                    studentid = student.StudentID,
                    studentname = student.FirstName + " " + student.LastName,
                    enrollyear = student.EnrollYear
                });
            }
            return enrollYearStudentNameList;
        }
    }
}
