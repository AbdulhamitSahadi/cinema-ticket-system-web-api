using CinemaTicketSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketSystem.Application.IRepositories.CategoryRepositories
{
    public interface ICategoryReadRepository : IReadAsyncRepository<Category>, IReadRepository<Category>
    {

    }
}
