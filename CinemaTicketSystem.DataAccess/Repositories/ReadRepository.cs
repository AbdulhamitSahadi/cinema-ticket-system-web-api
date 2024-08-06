using CinemaTicketSystem.Application.IRepositories;
using CinemaTicketSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketSystem.DataAccess.Repositories
{
    public class ReadRepository : IReadRepository<Category>
    {
        public IQueryable<Category> Table => throw new NotImplementedException();

        public IQueryable<Category> TableNoTracking => throw new NotImplementedException();

        public Category Get(Expression<Func<Category, bool>> expression, bool enableTracking = true, string? includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAll(Expression<Func<Category, bool>>? expression, bool enableTracking = true, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public IPaginate<Category> GetAllPaginate(Expression<Func<Category, bool>>? expression = null, Func<IQueryable<Category>, IOrderedQueryable<Category>>? orderBy = null, Func<IQueryable<Category>, IIncludableQueryable<Category, object>>? include = null, int index = 0, int size = 10, bool enableTracking = true, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
