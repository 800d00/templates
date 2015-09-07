using System.Web;
using System.Web.Optimization;

namespace MWA
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-2.1.4/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/validate/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/flexslider").Include(
            "~/Scripts/jquery.flexslider.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/fancybox").Include(
                      "~/Scripts/fancybox/jquery.fancybox.js",
                      "~/Scripts/fancybox/jquery.fancybox*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/waypoints").Include(
                      "~/Scripts/jquery.waypoints.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/site").Include(
                      "~/Scripts/jquery.scrollto.js",
                      "~/Scripts/respond/respond.js",
                      "~/Scripts/jquery.tweet.js",
                      "~/Scripts/Site.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      //"~/Content/bootstrap/bootstrap.css",
                      "~/Content/bootstrap/bootstrap*",
                      "~/Content/Site.css",
                      //"~/Content/fancybox/jquery.fancybox.css",
                      "~/Content/Clouds.css",
                      "~/Content/fancybox/jquery.fancybox*",
                      "~/Content/Site-Responsive.css",
                      "~/Content/font-awesome/font-awesome.css",
                      "~/Content/flexslider/flexslider.css"));
        }
    }
}
