using CinemaTicketSystem.Application.IRepositories;
using CinemaTicketSystem.Domain.Common;
using CinemaTicketSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
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


        private readonly TContext _context;

        public WriteRepository(TContext context)
        {
            _context = context;
        }


        public IQueryable<TEntity> Table => _context.Set<TEntity>();

        public IQueryable<TEntity> TableNoTracking => _context.Set<TEntity>().AsNoTracking();

        public TEntity Add(TEntity entity)
        {
            _context.Add(entity);
            return entity;
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _context.AddRange(entities);
        }

        public void Delete(TEntity entity)
        {
            _context.Remove(entity);
        }

        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            _context.RemoveRange(entities);
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _context.Update(entity);
        }

        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            _context.UpdateRange(entities);
        }
    }
}
