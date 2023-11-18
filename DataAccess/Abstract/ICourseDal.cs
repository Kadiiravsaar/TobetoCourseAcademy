using Core.DataAccess;
using Entities.Concretes;
using Entities.Dto;

namespace DataAccess.Abstract
{
    public interface ICourseDal : IEntityRepositoryBase<Course>
    {
        //Course GetCourseWithCategory(Expression<Func<Course,bool>> filter);
        List<CourseDetailDto> GetCourseDetail();
    }
}
