using System;
using System.Collections.Generic;

namespace DeepBlue.Infra.Data.Contracts.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Create(TEntity entity);
        void Update(TEntity entity);
        TEntity Remove(Guid id);
        List<TEntity> SelectAll();
        TEntity SelectById(Guid id);
    }
}
