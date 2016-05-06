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
    [ServiceContract]
    public interface IServiceTicket
    {
        [OperationContract]
        //[WebInvoke]
        [WebInvoke(UriTemplate = "/AddTicket", Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        Ticket Add(Ticket ticket);

        [OperationContract]
        [WebGet(UriTemplate = "/GetTicket?id={id}", ResponseFormat = WebMessageFormat.Json)]
        Ticket Get(int id);

        [OperationContract]
        [WebGet(UriTemplate = "/Ticket", ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<Ticket> GetAll();
    }
}
