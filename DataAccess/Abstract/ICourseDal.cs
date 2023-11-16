using Core.DataAccess;
using Entites.Concrete;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICourseDal : IEntityRepositoryBase<Course>
    {
        //Course GetCourseWithCategory(Expression<Func<Course,bool>> filter);
        List<CourseDetailDto> GetCourseDetail();
    }
}
