using Core;
using Core.Dapper;
using Core.Domain.WeChat;
using Core.Repository;
using Ninject;
using Service.Interface;
using Service.WeChat;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebApp.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            var connectionFactory = new ConnectionFactory(ConfigurationManager.ConnectionStrings["DbConnection"]);
            kernel.Bind<IDbContext>().To<DbContext>()
                .WithConstructorArgument("connection", connectionFactory.Create());

            kernel.Bind<IMpAppConfigRepository>().To<MpAppConfigRepository>();




            kernel.Bind<IWeChatService>().To<WeChatService>();
        }
    }
}