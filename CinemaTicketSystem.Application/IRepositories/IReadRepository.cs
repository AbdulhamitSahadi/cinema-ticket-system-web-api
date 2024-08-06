using CinemaTicketSystem.Domain.Common;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketSystem.Application.IRepositories
{
    public interface IReadRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        #region GetAll
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>>? expression,
                              bool enableTracking = true,
                              CancellationToken cancellationToken = default);
        IPaginate<TEntity> GetAllPaginate(Expression<Func<TEntity, bool>>? expression = null,
                                    Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
                                    Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
                                    int index = 0,
                                    int size = 10,
                                    bool enableTracking = true,
                                    CancellationToken cancellationToken = default);
        #endregion



        #region Get
        TEntity Get(Expression<Func<TEntity, bool>> expression,
              bool enableTracking = true,
              string? includeProperties = null);
        #endregion
    }
}
