using CinemaTicketSystem.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketSystem.Application.IRepositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        #region Insert
        T Add(T entity);
        void AddRange(IEnumerable<T> entities);
        #endregion


        #region Update
        void Update(T entity);
        void UpdateRange(IEnumerable<T> entities);
        #endregion


        #region Delete
        void Delete(T entity);
        void DeleteRange(IEnumerable<T> entities);
        #endregion


        #region Save
        int Save();
        #endregion
    }
}
