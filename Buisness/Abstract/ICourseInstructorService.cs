using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface ICourseInstructorService
    {
        List<CourseInstructor> GetAll();
        CourseInstructor GetById(int courseInstructorId);
        void Add(CourseInstructor courseInstructor);
        void Delete(CourseInstructor courseInstructor);
        void Update(CourseInstructor courseInstructor);

    }
}

