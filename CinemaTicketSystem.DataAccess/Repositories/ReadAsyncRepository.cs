using CinemaTicketSystem.Application.IRepositories;
using CinemaTicketSystem.Domain.Common;
using CinemaTicketSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketSystem.DataAccess.Repositories
{
    public class ReadAsyncRepository<TEntity, TContext> : ReadRepository, IReadAsyncRepository<TEntity>
        where TEntity : BaseEntity
        where TContext : DbContext
    {
        public IQueryable<TEntity> Table => throw new NotImplementedException();

        public IQueryable<TEntity> TableNoTracking => throw new NotImplementedException();

        public Task<IReadOnlyList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? expression = null)
        {
            throw new NotImplementedException();
        }
         
        public Task<IPagigate<TEntity>> GetAllPaginateAsync(Expression<Func<TEntity, bool>>? expression = null, 
                                                            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, 
                                                            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, 
                                                            int index = 0, 
                                                            int size = 10, 
                                                            bool enableTracking = true, 
                                                            CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetAsync(Expression<Func<int, bool>> expression, 
                                       bool enableTracking = true, 
                                       string? includeProperties = null)
        {
            throw new NotImplementedException();
        }
    }
}
