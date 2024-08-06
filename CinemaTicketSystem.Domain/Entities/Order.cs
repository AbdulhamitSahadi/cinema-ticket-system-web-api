using CinemaTicketSystem.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketSystem.Domain.Entities
{
    public class Order : BaseAuditableEntity
    {
        public int Id { get; set; }
    }
}
