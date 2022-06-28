using System.Web;
using System.Web.Optimization;

namespace genztrend
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
           /* bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
*/

            bundles.Add(new ScriptBundle("~/bundles/site_script").Include(
                "~/Scripts/jquery-3.2.1.min.js",
                "~/Plugins/zebra-tooltip/zebra_tooltips.min.js",
                "~/Plugins/owl-carousel/owl.carousel.min.js",
                "~/Scripts/main-script.js"));


            bundles.Add(new StyleBundle("~/Content/site_css").Include(
          "~/Plugins/zebra-tooltip/zebra_tooltips.min.css",
          "~/Plugins/owl-carousel/assets/owl.carousel.min.css",
          "~/Content/main-style.css",
          "~/Content/thu_khung_que.css",
          "~/Content/responsive-style.css"));

        }
    }
}
