using Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Web;

namespace WcfServiceShopList
{
    [ServiceContract]
    public interface IServiceArticle
    {
        [OperationContract]
        [WebGet(UriTemplate = "/Articles", ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<Article> GetAll();
    }
}