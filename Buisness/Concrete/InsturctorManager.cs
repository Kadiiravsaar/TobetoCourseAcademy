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
    public class InsturctorManager : BaseManager<Instructor>, IInsturctorService
    {
        public InsturctorManager(IEntityBaseRepository<Instructor> entityRepository) : base(entityRepository)
        {
        }
    }
}
