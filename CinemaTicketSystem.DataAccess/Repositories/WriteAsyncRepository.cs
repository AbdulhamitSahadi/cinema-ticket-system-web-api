using CinemaTicketSystem.Application.IRepositories;
using CinemaTicketSystem.Domain.Common;
using CinemaTicketSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketSystem.DataAccess.Repositories
{
    public class WriteAsyncRepository<TEntity, TContext> : WriteRepository<TEntity, TContext>, IWriteAsyncRepository<TEntity>
        where TEntity : BaseEntity
        where TContext : DbContext
    {

        private readonly TContext _context;

        public WriteAsyncRepository(TContext context) : base(context)
        {
            _context = context;
        }


        public IQueryable<TEntity> Table => _context.Set<TEntity>();

        public IQueryable<TEntity> TableNoTracking => _context.Set<TEntity>().AsNoTracking();

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            return entity;
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _context.Set<TEntity>().AddRangeAsync(entities);
        }

        public async Task DeleteAsync(TEntity entity)
        {
            _context.Remove(entity);
        }

        public async Task DeleteRangeAsync(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().RemoveRange(entities);
        }

        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            _context.Update(entity);
        }

        public async Task UpdateRangeAsync(IEnumerable<TEntity> entities)
        {
            _context.UpdateRange(entities);
        }
    }
}
