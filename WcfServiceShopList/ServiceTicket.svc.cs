using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Tickets;

namespace WcfServiceShopList
{
    public class ServiceTicket : IServiceTicket
    {
        readonly IServiceTicket _serviceTicket;
        public ServiceTicket(IServiceTicket serviceTicket)
        {
            if(null==serviceTicket)
            {
                throw new ArgumentNullException("Ticket Service");
            }
            _serviceTicket = serviceTicket;
        }

        public Ticket Add(Ticket ticket)
        {
            return _serviceTicket.Add(ticket);
        }

        public Ticket Get(int id)
        {

            return _serviceTicket.Get(id);
        }

        public IEnumerable<Ticket> GetAll()
        {

            return _serviceTicket.GetAll();
        }
    }
}
