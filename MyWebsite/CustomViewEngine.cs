using System.Web.Mvc;

namespace MyWebsite
{
    public abstract class CustomViewEngine : RazorViewEngine
    {
        public CustomViewEngine(string fileExtension)
        {
            base.AreaViewLocationFormats = new string[] {
                "~/Areas/{2}/Views/{1}/{0}." + fileExtension,
                "~/Areas/{2}/Views/Shared/{0}." + fileExtension
            };
            base.AreaMasterLocationFormats = new string[] {
                "~/Areas/{2}/Views/{1}/{0}." + fileExtension,
                "~/Areas/{2}/Views/Shared/{0}." + fileExtension
            };
            base.AreaPartialViewLocationFormats = new string[] {
                "~/Areas/{2}/Views/{1}/{0}." + fileExtension,
                "~/Areas/{2}/Views/Shared/{0}." + fileExtension
            };
            base.ViewLocationFormats = new string[] {
                "~/Views/{1}/{0}." + fileExtension,
                "~/Views/Shared/{0}." + fileExtension
            };
            base.MasterLocationFormats = new string[] {
                "~/Views/{1}/{0}." + fileExtension,
                "~/Views/Shared/{0}." + fileExtension
            };
            base.PartialViewLocationFormats = new string[] {
                "~/Views/{1}/{0}." + fileExtension,
                "~/Views/Shared/{0}." + fileExtension
            };
            base.FileExtensions = new string[] { fileExtension };
        }
    }
}