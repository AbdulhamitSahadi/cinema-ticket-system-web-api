using CinemaTicketSystem.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query;

namespace CinemaTicketSystem.Application.IRepositories
{
    public interface IReadAsyncRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        #region GetAll
        Task<IReadOnlyList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? expression = null);
        Task<IPagigate<TEntity>> GetAllPaginateAsync(Expression<Func<TEntity, bool>>? expression = null,
                                               Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
                                               Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
                                               int index = 0,
                                               int size = 10,
                                               bool enableTracking = true,
                                               CancellationToken cancellationToken = default);
        #endregion



        #region Get
        Task<TEntity> GetAsync(Expression<Func<int, bool>> expression,
                         bool enableTracking = true,
                         string? includeProperties = null);
        #endregion
    }
}
