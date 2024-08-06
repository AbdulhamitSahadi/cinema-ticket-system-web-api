using CinemaTicketSystem.Application.IRepositories;
using CinemaTicketSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketSystem.DataAccess.Repositories
{
    public class WriteRepository : IWriteRepository<Category>
    {
        public IQueryable<Category> Table => throw new NotImplementedException();

        public IQueryable<Category> TableNoTracking => throw new NotImplementedException();

        public Category Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Category> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(IEnumerable<Category> entities)
        {
            throw new NotImplementedException();
        }

        public int Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateRange(IEnumerable<Category> entities)
        {
            throw new NotImplementedException();
        }
    }
}
