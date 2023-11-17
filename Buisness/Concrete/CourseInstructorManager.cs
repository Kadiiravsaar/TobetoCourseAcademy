using Buisness.Abstract;
using Buisness.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entites.Concrete;
using Entites.DTOs;

namespace Buisness.Concrete
{
    public class CourseInstructorManager : ICourseInstructorService
    {
        ICourseInstructorDal _courseInstructorDal;
        public CourseInstructorManager(ICourseInstructorDal courseInstructorDal)
        {
            _courseInstructorDal = courseInstructorDal;
        }
        public IResult Add(CourseInstructor courseInstructor)
        {
            _courseInstructorDal.Add(courseInstructor);
            return new SuccessResult(Messages.Added);

        }

        public IResult Delete(CourseInstructor courseInstructor)
        {
            _courseInstructorDal.Delete(courseInstructor);
            return new SuccessResult(Messages.Deleteded);

        }

        public IDataResult<List<CourseInstructor>> GetAll()
        {
            return new SuccessDataResult<List<CourseInstructor>>(_courseInstructorDal.GetAll(),Messages.Listed);
        }

        public IDataResult<List<CourseInstructorDto>> GetAllDetail()
        {
            return new SuccessDataResult<List<CourseInstructorDto>>(_courseInstructorDal.GetAllDetail(), Messages.Listed);
        }

        public IDataResult<CourseInstructor> GetById(int courseInstructorId)
        {
            return new SuccessDataResult<CourseInstructor>(_courseInstructorDal.Get(p => p.Id == courseInstructorId),Messages.GetData);
        }

        public IResult Update(CourseInstructor courseInstructor)
        {
            _courseInstructorDal.Update(courseInstructor);
            return new SuccessResult(Messages.Updated);

        }
    }
}