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
    public class CategoryManager : BaseManager<Category>, ICategoryService
    {
        public CategoryManager(IEntityBaseRepository<Category> entityRepository) : base(entityRepository)
        {
        }
    }
}
