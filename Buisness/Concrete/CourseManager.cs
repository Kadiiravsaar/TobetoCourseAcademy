using Buisness.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Concrete
{
    public class CourseManager : BaseManager<Course>, ICourseService
    {
        ICourseDal _courseDal;

        public CourseManager(IEntityBaseRepository<Course> entityRepository, ICourseDal courseDal) : base(entityRepository)
        {
            _courseDal = courseDal;
        }

        public Course GetCourse(int id)
        {
            return _courseDal.GetCourseWithCategory(x => x.Id == id);
        }
       
    }
}
