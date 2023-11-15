using Entites.Concrete;

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
