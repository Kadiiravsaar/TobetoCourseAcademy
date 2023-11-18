using Business.Abstracts;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concretes;
using Entities.Dto;

namespace Business.Concretes
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public IResult Add(Course course)
        {
            _courseDal.Add(course);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Course course)
        {
            _courseDal.Delete(course);
            return new SuccessResult(Messages.Deleteded);
        }

        public IDataResult<List<Course>> GetAll()
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(), Messages.Listed);
        }

        public IDataResult<List<Course>> GetAllByUnitPrice(double minValue, double maxValue)
        {
            return new SuccessDataResult<List<Course>>
                (_courseDal.GetAll(p => p.Price > minValue && p.Price < maxValue), Messages.GetData);
        }

        public IDataResult<Course> GetById(int id)
        {
            return new SuccessDataResult<Course>(_courseDal.Get(x => x.Id == id), Messages.GetData);
        }

        public IDataResult<List<CourseDetailDto>> GetCourseDetail()
        {
            if (DateTime.Now.Hour == 13)
            {
                return new ErrorDataResult<List<CourseDetailDto>>("Sistem Bakımda");

            }
            return new SuccessDataResult<List<CourseDetailDto>>(_courseDal.GetCourseDetail(), Messages.GetCourseDetail);
        }

        public IResult Update(Course course)
        {
            _courseDal.Update(course);
            return new SuccessResult(Messages.Updated);

        }
    }
}
