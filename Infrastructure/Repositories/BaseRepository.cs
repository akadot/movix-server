using System;
using System.Linq.Expressions;
using Infrastructure.Context;
using Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
{
    private readonly MovixContext _context;
    public BaseRepository(MovixContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<TEntity?>> GetAll()
    {
        return await _context.Set<TEntity>().AsNoTracking().ToListAsync();
    }

    public async Task<IEnumerable<TEntity?>> GetAllByFilter(Expression<Func<TEntity, bool>> expression)
    {
        return await _context.Set<TEntity>().AsNoTracking().Where(expression).ToListAsync();
    }

    public async Task<TEntity?> GetByFilter(Expression<Func<TEntity, bool>> expression)
    {
        return await _context.Set<TEntity>().AsNoTracking().Where(expression).FirstOrDefaultAsync();
    }

    public async Task<TEntity?> Create(TEntity entity)
    {
        _context.Set<TEntity>().Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<TEntity?> Remove(TEntity entity)
    {
        _context.Set<TEntity>().Remove(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<TEntity?> Update(TEntity entity)
    {
        _context.Set<TEntity>().Update(entity);
        await _context.SaveChangesAsync();
        return entity;
    }
}
