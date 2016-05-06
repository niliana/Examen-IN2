using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets;

namespace Infraestructure
{
    public class RepositoryTicket: RepositoryBase<Ticket>, IRepositoryTicket
    {
        public RepositoryTicket(IDbContext context)
            : base(context)
        {

        }


        public Ticket Add(Ticket ticket)
        {
            Entity.Add(ticket);
            return ticket;
        }

        public Ticket Get(int id)
        {
            return Entity.Where(t => t.TicketId == id).FirstOrDefault();
     
        }

        public IEnumerable<Ticket> GetAll()
        {
            return Entity.Select(t => t);
        }
    }
}
