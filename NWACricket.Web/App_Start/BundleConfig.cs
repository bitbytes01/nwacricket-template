using System.Web;
using System.Web.Optimization;

namespace NWACricket.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-1.*"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui*"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/weatherfeed").Include("~/Scripts/jquery.zweatherfeed.min.js"));
            bundles.Add(new StyleBundle("~/Content/weatherfeed").Include("~/Content/weatherfeed.css"));

            bundles.Add(new ScriptBundle("~/bundles/poll").Include("~/Scripts/jquery.cookie.js", "~/Scripts/poll.js"));
            bundles.Add(new StyleBundle("~/Content/poll").Include("~/Content/poll.css"));


            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css", "~/Content/nwacricket.css",
                         "~/Content/style.css",
                         "~/Content/print.css",
                         "~/Content/nav/navbar.css"));

            //adding table style
            bundles.Add(new StyleBundle("~/Content/tablecss").Include("~/Content/table.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquerymobile").Include("~/Scripts/jquery.mobile*"));

            bundles.Add(new StyleBundle("~/Content/mobilecss").Include("~/Content/jquery.mobile*", "~/Content/MobileSite.css"));
        }
    }
}