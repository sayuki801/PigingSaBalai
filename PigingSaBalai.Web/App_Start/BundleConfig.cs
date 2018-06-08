using System.Web;
using System.Web.Optimization;

namespace MyProject1
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            
            #region Scripts

            bundles.Add(new ScriptBundle("~/Content/main_Scripts").Include(
                      "~/Content/vendor/jquery/jquery-3.2.1.min.js",
                      "~/Content/vendor/animsition/js/animsition.min.js",
                      "~/Content/vendor/bootstrap/js/popper.js",
                      "~/Content/vendor/bootstrap/js/bootstrap.min.js",
                      "~/Content/vendor/select2/select2.min.js",
                      "~/Content/vendor/daterangepicker/moment.min.js",
                      "~/Content/vendor/daterangepicker/daterangepicker.js",
                      "~/Content/vendor/slick/slick.min.js",
                      "~/Content/js/slick-custom.js",
                      "~/Content/vendor/countdowntime/countdowntime.js",
                      "~/Content/vendor/lightbox2/js/lightbox.min.js",
                      "~/Content/js/main.js"
                      ));

            #endregion

            #region Styles

                   bundles.Add(new StyleBundle("~/Content/main_Style").Include(
                      "~/Content/vendor/bootstrap/css/bootstrap.min.css",
                      "~/Content/fonts/font-awesome-4.7.0/css/font-awesome.min.css",
                      "~/Content/fonts/themify/themify-icons.css",
                      "~/Content/vendor/animate/animate.css",
                      "~/Content/vendor/css-hamburgers/hamburgers.min.css",
                      "~/Content/vendor/animsition/css/animsition.min.css",
                      "~/Content/vendor/select2/select2.min.css",
                      "~/Content/vendor/daterangepicker/daterangepicker.css",
                      "~/Content/vendor/slick/slick.css",
                      "~/Content/vendor/lightbox2/css/lightbox.min.css",
                      "~/Content/css/util.css",
                      "~/Content/css/main.css"));

            #endregion
        }
    }
}
