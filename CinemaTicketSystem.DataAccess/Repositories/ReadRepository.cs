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

        private readonly TContext _context;

        public ReadRepository(TContext context)
        {
            _context = context;
        }

        public IQueryable<TEntity> Table => _context.Set<TEntity>();

        public IQueryable<TEntity> TableNoTracking => _context.Set<TEntity>().AsNoTracking();

        public TEntity Get(Expression<Func<TEntity, bool>> expression, 
                           bool enableTracking = true, 
                           string? includeProperties = null)
        {

            IQueryable<TEntity> query = Table;

            query = query.Where(expression);

            if (!enableTracking)
                query = query.AsNoTracking();

            if(includeProperties != null)
            {
                foreach(var property in includeProperties.Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(property);
                }
            }


            return query.FirstOrDefault();   
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>>? expression, 
                                            bool enableTracking = true, 
                                            CancellationToken cancellationToken = default)
        {
            IQueryable<TEntity> query = Table;

            if(expression != null)
            {
                query = query.Where(expression);
            }

            if(!enableTracking)
                query = query.AsNoTracking();

            return query.ToList();
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
