using Buisness.Abstract;
using DataAccess.Abstract;
using Entites.Concrete;
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

        public void Add(Course course)
        {
            _courseDal.Add(course);
        }

        public void Delete(Course course)
        {
            _courseDal.Delete(course);

        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

        public List<Course> GetAllByUnitPrice(double minValue, double maxValue)
        {
            return _courseDal.GetAll(p => p.Price > minValue && p.Price < maxValue);
        }

        public Course GetById(int id)
        {
            return _courseDal.Get(c => c.Id == id);
        }

        public void Update(Course course)
        {
            _courseDal.Update(course);

        }
    }
}