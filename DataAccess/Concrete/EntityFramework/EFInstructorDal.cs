using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concretes;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFInstructorDal : EfEntityRepositoryBase<Instructor, AppDbContext>, IInstructorDal
    {
    }
}
