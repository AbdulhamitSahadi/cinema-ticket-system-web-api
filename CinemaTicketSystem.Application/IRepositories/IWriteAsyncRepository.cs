using CinemaTicketSystem.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketSystem.Application.IRepositories
{
    public interface IWriteAsyncRepository<T> : IRepository<T> where T : BaseEntity
    {
        #region Insert
        Task<T> AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        #endregion


        #region Update
        Task UpdateAsync(T entity);
        Task UpdateRangeAsync(IEnumerable<T> entities);
        #endregion


        #region
        Task DeleteAsync(T entity);
        Task DeleteRangeAsync(IEnumerable<T> entities);
        #endregion


        #region Save
        Task<int> Save();
        #endregion
    }
}
