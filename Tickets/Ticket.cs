using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets
{
    public class Ticket
    {
        public Ticket()
        {
            Operations = new List<Operation>();
        }
        public int TicketId { get; set; }
        public DateTime Date { get; set; }
        public virtual IEnumerable<Operation> Operations { get; set; }
    }
}
