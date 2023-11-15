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
    public class CourseInstructorManager : ICourseInstructorService
    {
        ICourseInstructorDal _courseInstructorDal;
        public CourseInstructorManager(ICourseInstructorDal courseInstructorDal)
        {
            _courseInstructorDal = courseInstructorDal;
        }
        public void Add(CourseInstructor courseInstructor)
        {
            _courseInstructorDal.Add(courseInstructor);
        }

        public void Delete(CourseInstructor courseInstructor)
        {
            _courseInstructorDal.Delete(courseInstructor);
        }

        public List<CourseInstructor> GetAll()
        {
            return _courseInstructorDal.GetAll();
        }

        public CourseInstructor GetById(int courseInstructorId)
        {
            return _courseInstructorDal.Get(p => p.Id == courseInstructorId);
        }

        public void Update(CourseInstructor courseInstructor)
        {
            _courseInstructorDal.Update(courseInstructor);
        }
    }
}