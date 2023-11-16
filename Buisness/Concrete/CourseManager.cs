using Buisness.Abstract;
using Buisness.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entites.Concrete;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Concrete
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
            return new SuccessResult(Messages.CourseAdded);
        }

        public IResult Delete(Course course)
        {
            _courseDal.Delete(course);
            return new SuccessResult(Messages.CourseDeleted);
        }

        public IDataResult<List<Course>> GetAll()
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(),Messages.CourseListed);
        }

        public IDataResult<List<Course>> GetAllByUnitPrice(double minValue, double maxValue)
        {
            return new SuccessDataResult<List<Course>>
                (_courseDal.GetAll(p => p.Price > minValue && p.Price < maxValue), Messages.GetCourse);
        }

        public IDataResult<Course> GetById(int id)
        {
            return new SuccessDataResult<Course>(_courseDal.Get(x => x.Id == id), Messages.GetCourse);
        }

        public IDataResult<List<CourseDetailDto>> GetCourseDetail()
        {
            if (DateTime.Now.Hour == 14)
            {
                return new ErrorDataResult<List<CourseDetailDto>>("Sistem Bakımda");
                
            }
            return new SuccessDataResult<List<CourseDetailDto>>(_courseDal.GetCourseDetail(), Messages.GetCourseDetail);
        }

        public IResult Update(Course course)
        {
            _courseDal.Update(course);
            return new SuccessResult(Messages.CourseUpdated);


        }
    }
}