using System;
using System.Linq.Expressions;

namespace Infrastructure.Interfaces;

public interface IBaseRepository<TEntity> where TEntity : class
{
    Task<IEnumerable<TEntity?>> GetAll();
    Task<IEnumerable<TEntity?>> GetAllByFilter(Expression<Func<TEntity, bool>> expression);
    Task<TEntity?> GetByFilter(Expression<Func<TEntity, bool>> expression);
    Task<TEntity?> Create(TEntity entity);
    Task<TEntity?> Update(TEntity entity);
    Task<TEntity?> Remove(TEntity entity);
}
