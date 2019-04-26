using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using AutoMapper;
using ClinicSolution.Persistence;
using ClinicSolution.WebApi.App_Start;
using Unity;

namespace ClinicSolution.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var mapperConfig = MappingProfile.InitializeAutoMapper();
            IMapper mapper = mapperConfig.CreateMapper();
  
            var container = new UnityContainer();
            container.RegisterInstance(mapper);
            //container.RegisterType<>();
            config.DependencyResolver = new UnityResolver(container);

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
