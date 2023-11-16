using Core.Utilities.Results;
using Entites.Concrete;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface ICourseService
    {
        IDataResult<List<Course>> GetAll();
        IDataResult<List<Course>> GetAllByUnitPrice(double minValue, double maxValue);
        IDataResult<List<CourseDetailDto>> GetCourseDetail();
        //List<Course> GetAllByCategoryId(int categoryId);
        IDataResult<Course> GetById(int id);
        IResult Add(Course course);
        IResult Delete(Course course);
        IResult Update(Course course);
    }
}
