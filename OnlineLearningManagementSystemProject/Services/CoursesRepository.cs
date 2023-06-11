using OnlineLearningManagementSystemProject.Models;

namespace OnlineLearningManagementSystemProject.Services
{
    public class CoursesRepository : ICoursesRepository
    {
        LMSContext context;

        public CoursesRepository(LMSContext _context)
        {
            context = _context;
        }

        public int creatCourse(Course crs, IFormFile? Picture)
        {
            if (Picture != null && Picture.Length > 0)
            {
                var fileName = Path.GetFileName(Picture.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\courseimage", fileName);
                crs.CourseImage = "~/courseimage/" + fileName;
            }
            context.Courses.Add(crs);
            int raw = context.SaveChanges();
            return raw;
        }

        public int deleteCourse(int id)
        {
            Course crs = context.Courses.FirstOrDefault(c => c.CourseId == id);
            context.Courses.Remove(crs);
            int raw = context.SaveChanges();
            return raw;
        }

        public List<Course> GetCourse()
        {
            return context.Courses.ToList();
        }

        public Course GetCourseById(int id)
        {
            return context.Courses.FirstOrDefault(c => c.CourseId == id);
        }

        public int updateCourse(int id, Course crs)
        {
            Course oldcrs = context.Courses.FirstOrDefault(c => c.CourseId == id);
            oldcrs.Lecture = crs.Lecture;
            oldcrs.CourseCode = crs.CourseCode;
            oldcrs.Lab = crs.Lab;
            oldcrs.CourseImage = crs.CourseImage;
            oldcrs.Credit = crs.Credit;
            oldcrs.Training = crs.Training;
            oldcrs.CourseName = crs.CourseName;
            int raw = context.SaveChanges();
            return raw;
        }
    }
}
