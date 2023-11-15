using Core.Entities;

namespace Entites.Concrete
{
    public class Instructor : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<CourseInstructor> CourseInstructors { get; set; }
    }
}
