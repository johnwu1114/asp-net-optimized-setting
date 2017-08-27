using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using MyWebsite;

[assembly: PreApplicationStartMethod(typeof(RemoveHeaderModule), "Register")]

namespace MyWebsite
{
    public class RemoveHeaderModule : IHttpModule
    {
        private static readonly List<string> _removeHeaders = new List<string>
        {
            "Server",
            "X-AspNet-Version",
            //"X-AspNetMvc-Version",
            "ETag"
        };

        public static void Register()
        {
            DynamicModuleUtility.RegisterModule(typeof(RemoveHeaderModule));
            MvcHandler.DisableMvcResponseHeader = true;
        }

        public void Init(HttpApplication context)
        {
            context.PreSendRequestHeaders += OnPreSendRequestHeaders;
        }

        public void Dispose()
        {
        }

        private void OnPreSendRequestHeaders(object sender, EventArgs e)
        {
            if (HttpContext.Current != null)
            {
                var response = HttpContext.Current.Response;
                _removeHeaders.ForEach(header => { response.Headers.Remove(header); });
            }
        }
    }
}