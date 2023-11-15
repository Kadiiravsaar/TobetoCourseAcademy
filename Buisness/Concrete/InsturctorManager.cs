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
    public class InsturctorManager : IInsturctorService
    {
        IInstructorDal _instructorDal;

        public InsturctorManager(IInstructorDal ınstructorDal)
        {
            _instructorDal = ınstructorDal;
        }

        public void Add(Instructor instructor)
        {
            _instructorDal.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            _instructorDal.Delete(instructor);
        }

        public List<Instructor> GetAll()
        {
            return _instructorDal.GetAll();
        }

        public Instructor GetById(int id)
        {
            return _instructorDal.Get(p => p.Id == id);
        }

        public void Update(Instructor instructor)
        {
            _instructorDal.Update(instructor);

        }
    }
}
