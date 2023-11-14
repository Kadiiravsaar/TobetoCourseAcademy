using Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface IBaseService<TEntity> where TEntity : class,IEntity,new()
    {
        List<TEntity> GetAll();
        void Add(TEntity entity);
    }
}
