using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyWebsite
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new CSharpViewEngine());
        }
    }
}