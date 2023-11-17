using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entites.Concrete;
using Entites.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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
                var result = from course in context.Courses

                             join courseInstructor in context.CourseInstructors
                             on course.Id equals courseInstructor.CourseId

                             join instructor in context.Instructors
                             on courseInstructor.InstructorId equals instructor.Id

                             select new CourseDetailDto
                             {
                                CourseId =course.Id,
                                CourseName =course.Name,    
                                Price = course.Price,
                                InstructorName = instructor.Name
                                
                             };
                return result.ToList();
            }
        }
    }
}
