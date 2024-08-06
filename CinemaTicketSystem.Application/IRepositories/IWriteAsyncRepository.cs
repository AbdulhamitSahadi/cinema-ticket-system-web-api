using CinemaTicketSystem.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketSystem.Application.IRepositories
{
    public interface IWriteAsyncRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        #region Insert
        Task<TEntity> AddAsync(TEntity entity);
        Task AddRangeAsync(IEnumerable<TEntity> entities);
        #endregion


        #region Update
        Task UpdateAsync(TEntity entity);
        Task UpdateRangeAsync(IEnumerable<TEntity> entities);
        #endregion


        #region
        Task DeleteAsync(TEntity entity);
        Task DeleteRangeAsync(IEnumerable<TEntity> entities);
        #endregion


        #region Save
        Task<int> Save();
        #endregion
    }
}
