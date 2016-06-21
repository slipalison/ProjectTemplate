using ProgectTemplate.Application.Interfaces;
using ProgectTemplate.Application.Service;
using ProgectTemplate.Business.Interfaces.Repository.Table;
using ProgectTemplate.Repository.Context;
using ProgectTemplate.Repository.Interfaces;
using ProgectTemplate.Repository.Repository.Table;
using ProgectTemplate.Repository.UoW;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using SimpleInjector.Integration.WebApi;
using System;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;

namespace ProgectTemplate.IoC
{
    public class Bootstrap
    {

        public static void RegisterServices(ImplementationType type, HttpConfiguration config = null)
        {
            var container = new Container();

            if (type == ImplementationType.API)
            {
                if (config == null)
                    throw new ArgumentException("O parametro HttpConfiguration não pode ser null para Web Api");
                container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();
                InitializeContainer(container);
                container.RegisterWebApiControllers(config);
                container.Verify();
                config.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
            }
            else
            {
                container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
                InitializeContainer(container);
                container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
                container.Verify();
                DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
            }

        }



        private static void InitializeContainer(Container container)
        {
            // Lifestyle.Transient => Uma instancia para cada solicitacao;
            // Lifestyle.Singleton => Uma instancia unica para a classe
            // Lifestyle.Scoped => Uma instancia unica para o request

            #region Application
            container.RegisterPerWebRequest<IUnitOfWork, UnitOfWork>();
            container.RegisterPerWebRequest<IWUserAppService, WUserAppService>();
            #endregion

            #region Business
            #endregion

            #region Infra Dados
            container.RegisterPerWebRequest<Context>();
            container.RegisterPerWebRequest<IWUserRepository, WUserRepository>();
            #endregion


            //EX: container.Register(typeof (IRepository<>), typeof (Repository<>));
        }


    }
    public enum ImplementationType
    {
        MVC = 0,
        API = 1,
        Web = 0
    }
}
