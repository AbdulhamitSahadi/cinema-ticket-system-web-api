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
    public class WriteRepository<TEntity, TContext> : IWriteRepository<TEntity>
        where TEntity : BaseEntity
        where TContext : DbContext
    {
        public IQueryable<TEntity> Table => throw new NotImplementedException();

        public IQueryable<TEntity> TableNoTracking => throw new NotImplementedException();

        public TEntity Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public int Save()
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }
    }
}
