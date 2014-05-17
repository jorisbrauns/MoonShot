using System.Collections.Generic;
using System.Web.Optimization;
using Nancy;

namespace Moonshot
{
    public class MainModule : NancyModule
    {
        public MainModule()
        {
            var scripts = new List<string>
            {
                Scripts.Render("~/bundles/bootstrap").ToString(),
                Scripts.Render("~/bundles/angular").ToString()
            };

            Get["/"] = _ =>
            {
                var t = Scripts.Render("~/Bundles/jquery");
                var model = new { 
                    title = "We've Got Nancy and Angular!",
                    scripts = string.Join("", scripts),
                    styles = Styles.Render("~/bundles/css").ToString() 
                };
                return View["Main", model];
            };
        }
    }
}