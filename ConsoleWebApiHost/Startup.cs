using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web.Http;
using Owin;

namespace WebApiHost
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            
            config.Routes.MapHttpRoute("DefaultApi", routeTemplate: "api/{controller}");

            app.UseWebApi(config);
        }
    }
}
