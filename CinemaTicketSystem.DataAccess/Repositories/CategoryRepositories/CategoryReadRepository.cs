using CinemaTicketSystem.Application.IRepositories;
using CinemaTicketSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketSystem.DataAccess.Repositories.CategoryRepositories
{
    public class CategoryReadRepository : ReadAsyncRepository, IReadAsyncRepository<Category>, IReadRepository<Category>
    {
    }
}
