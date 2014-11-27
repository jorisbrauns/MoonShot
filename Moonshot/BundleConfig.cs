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
                //Requirements
                "~/Scripts/angular.js",
                "~/Scripts/angular-ui/ui-bootstrap-tpls.js",
                "~/Scripts/angular-route.js",
                "~/Scripts/angular-animate.js",

                //Base includes,
                "~/app.js",
                "~/Controllers/BaseController.js",
                "~/Controllers/*.js",
                "~/Directives/*.js",
                "~/Services/*.js",
                "~/Filters/*.js",
                "~/Plugins/*.js"
            ));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/site.css",
                "~/Content/loading-bar.css"
            ));

            BundleTable.EnableOptimizations = false;
        }
    }
}