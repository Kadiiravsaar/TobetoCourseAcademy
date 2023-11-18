using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concretes;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCategoryDal : EfEntityRepositoryBase<Category, AppDbContext>, ICategoryDal
    {

    }
}
