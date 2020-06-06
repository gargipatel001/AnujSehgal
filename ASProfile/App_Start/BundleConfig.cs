using System.Web;
using System.Web.Optimization;

namespace ASProfile
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Content/js").Include(
                        "~/Content/js/jquery-3.3.1.min.js",
                        "~/Content/js/popper.js",
                        "~/Content/js/bootstrap.min.js",
                        "~/Content/js/stellar.js",
                        "~/Content/js/jquery.ajaxchimp.min.js",
                        "~/Content/js/mail-script.js",
                        "~/Content/js/theme.js"));

            bundles.Add(new ScriptBundle("~/Content/vendors/js").Include(
                    "~/Content/vendors/lightbox/simpleLightbox.min.js",
                    "~/Content/vendors/nice-select/js/jquery.nice-select.min.js",
                    "~/Content/vendors/isotope/imagesloaded.pkgd.min.js",
                    "~/Content/vendors/isotope/isotope.pkgd.min.js",
                    "~/Content/vendors/owl-carousel/owl.carousel.min.js",
                    "~/Content/vendors/popup/jquery.magnific-popup.min.js",
                    "~/Content/vendors/counter-up/jquery.waypoints.min.js",
                    "~/Content/vendors/counter-up/jquery.counterup.min.js"
                    ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/bootstrap.css",
                      "~/Content/css/style.css",
                      "~/Content/css/responsive.css",
                      "~/Content/css/font-awesome.min.css"));
            bundles.Add(new StyleBundle("~/Content/scss").Include(
                  "~/Content/scss/_blog.scss",
                  "~/Content/scss/_button.scss",
                  "~/Content/scss/_contact.scss",
                  "~/Content/scss/_elements.scss",
                  "~/Content/scss/_feature.scss",
                  "~/Content/scss/_footer.scss",
                  "~/Content/scss/_gallery.scss",
                  "~/Content/scss/_header.scss",
                  "~/Content/scss/_predefine.scss",
                  "~/Content/scss/_testimonials.scss",
                  "~/Content/scss/_variables.scss",
                  "~/Content/scss/_breadcrumb.scss",
                   "~/Content/scss/_style.scss"));


            bundles.Add(new StyleBundle("~/Content/vendors/css").Include(
                      "~/Content/vendors/linericon/style.css",
                      "~/Content/vendors/owl-carousel/owl.carousel.min.css",
                      "~/Content/vendors/lightbox/simpleLightbox.css",
                      "~/Content/vendors/nice-select/css/nice-select.css",
                      "~/Content/vendors/animate-css/animate.css",
                      "~/Content/vendors/popup/magnific-popup.css",
                      "~/Content/vendors/flaticon/flaticon.css"));
        }
    }
}
