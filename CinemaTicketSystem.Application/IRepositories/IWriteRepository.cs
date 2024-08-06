using CinemaTicketSystem.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketSystem.Application.IRepositories
{
    public interface IWriteRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        #region Insert
        TEntity Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        #endregion


        #region Update
        void Update(TEntity entity);
        void UpdateRange(IEnumerable<TEntity> entities);
        #endregion


        #region Delete
        void Delete(TEntity entity);
        void DeleteRange(IEnumerable<TEntity> entities);
        #endregion


        #region Save
        int Save();
        #endregion
    }
}
