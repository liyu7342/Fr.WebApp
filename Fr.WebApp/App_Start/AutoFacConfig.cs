using Autofac;
using Autofac.Core;
using Autofac.Integration.Mvc;
using Fr.IAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace Fr.WebApp
{
    /// <summary>
    /// IOC 注入
    /// </summary>
    public class AutoFacConfig
    {
        public static void RegisterConfig()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            var adapter = System.Reflection.Assembly.Load("Fr.Adapter");
            builder.RegisterAssemblyTypes(adapter, adapter)
              .AsImplementedInterfaces();
            var service = System.Reflection.Assembly.Load("Fr.Service");
            builder.RegisterAssemblyTypes(service, service)
              .AsImplementedInterfaces();
            var repository = System.Reflection.Assembly.Load("Fr.Repositories");
            builder.RegisterAssemblyTypes(repository, repository)
              .AsImplementedInterfaces();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }
    }
}