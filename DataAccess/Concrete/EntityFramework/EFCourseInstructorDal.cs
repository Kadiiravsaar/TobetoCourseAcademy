using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entites.Concrete;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCourseInstructorDal : EfEntityRepositoryBase<CourseInstructor, AppDbContext>, ICourseInstructorDal
    {
        public List<CourseInstructorDto> GetAllDetail()
        {
            using (AppDbContext context = new AppDbContext())
            {
                var result = from courseInstructor in context.CourseInstructors
                             join course in context.Courses
                             on courseInstructor.CourseId equals course.Id

                             join instructor in context.Instructors
                             on courseInstructor.InstructorId equals instructor.Id

                             select new CourseInstructorDto
                             {
                                 CourseName = course.Name,
                                 InstructorName = instructor.Name
                             };
                return result.ToList();
            }
        }
    }
}
