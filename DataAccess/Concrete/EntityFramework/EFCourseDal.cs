using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concretes;
using Entities.Dto;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCourseDal : EfEntityRepositoryBase<Course, AppDbContext>, ICourseDal
    {
        //public Course GetCourseWithCategory(Expression<Func<Course, bool>> filter)
        //{
        //    using (AppDbContext _context = new AppDbContext())
        //    {
        //      return _context.Set<Course>()
        //            .Include(c => c.Category)
        //            .Include(c => c.CourseInstructors)
        //            .ThenInclude(ci=>ci.Instructor)
        //            .SingleOrDefault(filter);
        // }

        public List<CourseDetailDto> GetCourseDetail()
        {
            //using (AppDbContext context = new AppDbContext())
            //{
            //    var result = from co in context.Courses
            //                 join c in context.Categories
            //                 on co.CategoryId equals c.Id
            //                 //join i in context.Instructors
            //                 //on co.CourseInstructors equals i.CourseInstructors
            //                 join ci in context.CourseInstructors
            //                 on co.Id equals ci.CourseId
            //                 join i in context.Instructors
            //                 on ci.InstructorId equals i.Id
            //                 select new CourseDetailDto
            //                 {
            //                     CourseName = co.Name,
            //                     CategoryName = c.Name,
            //                     Price = co.Price,
            //                     InstructorName = "ass"
            //                 };
            //    return result.ToList();
            //}

            using (AppDbContext context = new AppDbContext())
            {
                var result = from courses in context.Courses
                             join categories in context.Categories
                             on courses.CategoryId equals categories.Id
                             select new CourseDetailDto
                             {
                                 CategoryName = categories.Name,
                                 CourseDescription = courses.Description,
                                 CourseImage = courses.ImageUrl,
                                 CoursePrice = courses.Price,
                                 CourseName = courses.Name,
                                 InstructorName = "ss"
                             };
                return result.ToList();
            }
        }
    }
}
