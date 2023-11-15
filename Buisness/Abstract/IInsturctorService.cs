using Entites.Concrete;

namespace Buisness.Abstract
{
    public interface IInsturctorService
    {
        List<Instructor> GetAll();
        Instructor GetById(int id);
        void Add(Instructor instructor);
        void Delete(Instructor instructor);
        void Update(Instructor instructor);
    }
}
