using System.Collections.Generic;

namespace Rittal.Shop.IServices
{
    public interface IEntityService<TEntity>
    {
        ICollection<TEntity> Get();
        TEntity Get(int id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(int id);
    }
}
