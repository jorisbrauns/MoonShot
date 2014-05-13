using System.Web.Optimization;

namespace Moonshot
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/jquery-{version}.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                "~/Scripts/angular.js",
                "~/Scripts/angular-route.js",
                "~/Controllers/Controller.js",
                "~/Controllers/HomeController.js",
                "~/app.js"
                //"~/Scripts/jquery-{version}.js"
            ));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                "~/Content/bootstrap.css"
            ));
        }
    }
}