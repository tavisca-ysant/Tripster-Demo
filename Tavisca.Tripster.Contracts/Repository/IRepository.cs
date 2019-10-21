using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Tripster.Contracts
{
    public interface IRepository<TEntity>  where TEntity : class
    {
        TEntity Get(Guid id);
        IEnumerable<TEntity> GetAll();
        void Add(TEntity entity);
        void Delete(Guid id);
        void Update(Guid id, TEntity entity);
    }
}
