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
    public class ReadRepository<TEntity, TContext> : IReadRepository<TEntity>
        where TEntity : BaseEntity
        where TContext : DbContext
    {
        public IQueryable<TEntity> Table => throw new NotImplementedException();

        public IQueryable<TEntity> TableNoTracking => throw new NotImplementedException();

        public TEntity Get(Expression<Func<TEntity, bool>> expression, 
                           bool enableTracking = true, 
                           string? includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>>? expression, 
                                            bool enableTracking = true, 
                                            CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public IPaginate<TEntity> GetAllPaginate(Expression<Func<TEntity, bool>>? expression = null, 
                                                   Func<IQueryable<Category>, IOrderedQueryable<TEntity>>? orderBy = null, 
                                                   Func<IQueryable<Category>, IIncludableQueryable<TEntity, object>>? include = null, 
                                                   int index = 0, 
                                                   int size = 10, 
                                                   bool enableTracking = true, 
                                                   CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
