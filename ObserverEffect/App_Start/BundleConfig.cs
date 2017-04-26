using System.Web;
using System.Web.Optimization;

namespace ObserverEffect
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery.js"));

            bundles.Add(new ScriptBundle("~/bundles/libs").Include(
                        "~/Scripts/tether/tether.min.js",
                        "~/Scripts/bootstrap.min.js",
                        "~/Scripts/jquery.easing/jquery.easing.min.js",
                        "~/Content/owl-carousel/owl.carousel.js",
                        "~/Content/magnific-popup/jquery.magnific-popup.min.js",
                        "~/Scripts/vide/jquery.vide.min.js",
                        "~/Scripts/mixitup/mixitup.min.js",
                        "~/Scripts/wowjs/wow.min.js",
                        "~/Scripts/contact_me.js",
                        "~/Scripts/jqBootstrapValidation.js",
                        "~/Scripts/vitality.js",
                        "~/Scripts/vitality-mixitup.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/font-awesome/css/font-awesome.min.css",
                      "~/Content/owl-carousel/owl.carousel.css",
                      "~/Content/owl-carousel/owl-carousel/owl.theme.css",
                      "~/Content/owl-carousel/owl-carousel/owl.transitions.css",
                      "~/Content/magnific-popup/magnific-popup.css",
                      "~/Content/animate.css/animate.min.css",
                      "~/Content/device-mockups/device-mockups.min.css",
                      "~/Content/vitality.css",
                      "~/Content/site.css"));
        }
    }
}
