using Microsoft.EntityFrameworkCore;
using OnlineLearningManagementSystemProject.Models;
using OnlineLearningManagementSystemProject.Services;

namespace OnlineLearningManagementSystemProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<LMSContext>(options =>
            {
                options.UseSqlServer("Data Source=ASMAA-KHAMIS\\SQLEXPRESS;Initial Catalog=OnlineLearningManagementSystem;Integrated Security=True");
            });
            builder.Services.AddScoped<IStudentRepository, StudentRepository>();
            builder.Services.AddScoped<ICoursesRepository, CoursesRepository>();
            builder.Services.AddScoped<IStaffRepository, StaffRepository>();
            builder.Services.AddScoped<IStudentCourseRepository, StudentCourseRepository>();
            builder.Services.AddScoped<IStaffCourseRepository, StaffCourseRepository>();
            builder.Services.AddScoped<IUploadStaffFileRepository, UploadStaffFileRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}