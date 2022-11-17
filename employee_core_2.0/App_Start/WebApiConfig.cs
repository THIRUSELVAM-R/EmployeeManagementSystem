using employee_core_2._0.Interfaces;
using employee_core_2._0.Repository;
using employee_core_2._0.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using Unity;

namespace employee_core_2._0
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            EnableCorsAttribute cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);
            // Web API configuration and services
            var container = new UnityContainer();

            container.RegisterType<IEmployeeService, EmployeeServices>();
            container.RegisterType<IEmployeeRepository, EmployeeRepository>();
            container.RegisterType<IJobdeptServices, JobdeptServices>();
            container.RegisterType<IJobdeptRepository, JobdeptRepository>();
            container.RegisterType<IFinanceServices, FinanceServices>();
            container.RegisterType<IFinanceRepository, FinanceRepository>();
            container.RegisterType<ILeaveServices, LeaveServices>();
            container.RegisterType<ILeaveRepository, LeaveRepository>();

            config.DependencyResolver = new UnityResolver(container);
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
