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
        public IQueryable<TEntity> Table => throw new NotImplementedException();

        public IQueryable<TEntity> TableNoTracking => throw new NotImplementedException();

        public Task<TEntity> AddAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRangeAsync(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRangeAsync(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }
    }
}
