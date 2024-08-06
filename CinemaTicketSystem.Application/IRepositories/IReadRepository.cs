﻿using CinemaTicketSystem.Domain.Common;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketSystem.Application.IRepositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        #region GetAll
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? expression,
                              bool enableTracking = true,
                              CancellationToken cancellationToken = default);
        IPaginate<T> GetAllPaginate(Expression<Func<T, bool>>? expression = null,
                                    Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
                                    Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
                                    int index = 0,
                                    int size = 10,
                                    bool enableTracking = true,
                                    CancellationToken cancellationToken = default);
        #endregion



        #region Get
        T Get(Expression<Func<T, bool>> expression
              bool enableTracking = true,
              string? includeProperties = null);
        #endregion
    }
}
