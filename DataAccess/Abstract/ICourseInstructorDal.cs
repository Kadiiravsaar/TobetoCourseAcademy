using Core.DataAccess;
using Entities.Concretes;

namespace DataAccess.Abstract
{
    public interface ICourseInstructorDal : IEntityRepositoryBase<CourseInstructor>
    {
        //List<CourseInstructorDto> GetAllDetail();
    }
}
