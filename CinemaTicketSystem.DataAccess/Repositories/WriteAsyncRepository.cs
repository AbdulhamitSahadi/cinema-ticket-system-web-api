using CinemaTicketSystem.Application.IRepositories;
using CinemaTicketSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketSystem.DataAccess.Repositories
{
    public class WriteAsyncRepository : WriteRepository, IWriteAsyncRepository<Category>
    {
        public IQueryable<Category> Table => throw new NotImplementedException();

        public IQueryable<Category> TableNoTracking => throw new NotImplementedException();

        public Task<Category> AddAsync(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task AddRangeAsync(IEnumerable<Category> entities)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRangeAsync(IEnumerable<Category> entities)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRangeAsync(IEnumerable<Category> entities)
        {
            throw new NotImplementedException();
        }
    }
}
