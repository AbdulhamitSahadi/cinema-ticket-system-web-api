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
    public interface IReadAsyncRepository<T> : IRepository<T> where T : BaseEntity
    {
        #region GetAll
        Task<IReadOnlyList<T>> GetAllAsync(Expression<Func<T, bool>>? expression = null);
        Task<IPagigate<T>> GetAllPaginateAsync(Expression<Func<T, bool>>? expression = null,
                                               Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
                                               Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
                                               int index = 0,
                                               int size = 10,
                                               bool enableTracking = true,
                                               CancellationToken cancellationToken = default);
        #endregion



        #region Get
        Task<T> GetAsync(Expression<Func<int, bool>> expression,
                         bool enableTracking = true,
                         string? includeProperties = null);
        #endregion
    }
}
