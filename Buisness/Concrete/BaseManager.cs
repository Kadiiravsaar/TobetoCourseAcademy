using Buisness.Abstract;
using DataAccess.Abstract;
using Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Concrete
{
    public class BaseManager<TEntity> : IBaseService<TEntity> where TEntity : class, IEntity, new()
    {
        IEntityBaseRepository<TEntity> _entityRepository;

        public BaseManager(IEntityBaseRepository<TEntity> entityRepository)
        {
            _entityRepository = entityRepository;
        }

        public void Add(TEntity entity)
        {
           _entityRepository.Add(entity);
        }

        public List<TEntity> GetAll()
        {
           return _entityRepository.GetAll();
        }
    }
}
