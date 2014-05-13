using System.Web.Optimization;
using Nancy;

namespace Moonshot
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ =>
            {
                var t = Scripts.Render("~/Bundles/jquery");
                var model = new { 
                    title = "We've Got Nancy and Angular!",
                    scripts = Scripts.Render("~/bundles/bootstrap").ToString(),
                    styles = Styles.Render("~/bundles/css").ToString() 
                };
                return View["home", model];
            };
        }
    }
}