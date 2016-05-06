using Articles;
using Autofac;
using Autofac.Integration.Wcf;
using Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tickets;



namespace WcfServiceShopList.ServiceConfig
{
    public class AutofacConfig
    {
        public static IContainer Register()
        {
            var builder = new ContainerBuilder();


            builder.RegisterType<ShopContext>().As<IDbContext>().As<IUnitOfWork>().InstancePerLifetimeScope();
            builder.RegisterType<ServiceTicket>().As<IServiceTicket>();
            builder.RegisterType<ServiceAritcle>().As<IServiceArticle>();
            builder.RegisterType<RepositoryArticle>().As<IRepositoryArticle>();
            builder.RegisterType<RepositoryTicket>().As<IRepositoryTicket>();

            return builder.Build();

        }

    }
}