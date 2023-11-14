using DataAccess.Abstract;
using Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCourseDal : EfEntityBaseRepository<Course, AppDbContext>, ICourseDal
    {
        public Course GetCourseWithCategory(Expression<Func<Course, bool>> filter)
        {
            using (AppDbContext _context = new AppDbContext())
            {
              return _context.Set<Course>()
                    .Include(c => c.Category)
                    .Include(c => c.CourseInstructors)
                    .ThenInclude(ci=>ci.Instructor)
                    .SingleOrDefault(filter);



            }
            
        }
    }
}
