using Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WcfServiceShopList
{
    public class ServiceAritcle : IServiceArticle
    {
        readonly IServiceArticle _serviceArticle;

        public ServiceAritcle(IServiceArticle serviceArticle)
        {
            if (null == serviceArticle)
            {
                throw new ArgumentNullException("Article Service");
            }
            _serviceArticle = serviceArticle;
        }

        public IEnumerable<Article> GetAll()
        {
            return _serviceArticle.GetAll();
        }


    }
}
