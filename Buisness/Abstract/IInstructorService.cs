using Core.Utilities.Results;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface IInstructorService
    {
        IDataResult<List<Instructor>> GetAll();
        IDataResult<Instructor> GetById(int id);
        IResult Add(Instructor instructor);
        IResult Delete(Instructor instructor);
        IResult Update(Instructor instructor);
    }
}
