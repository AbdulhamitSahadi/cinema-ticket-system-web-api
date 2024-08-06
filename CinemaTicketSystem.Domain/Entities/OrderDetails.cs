using CinemaTicketSystem.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketSystem.Domain.Entities
{
    public class OrderDetails : BaseAuditableEntity
    {
        public int Id { get; set; }

        public int Amount { get; set; }

        public decimal Price { get; set; }


        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public int OrderId { get; set; }

        public Order Order { get; set; }
    }
}
