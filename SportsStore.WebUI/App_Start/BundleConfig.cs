using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace SportsStore.WebUI
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/js").Include(
                "~/Scripts/jQuery.1.7.1.js")
            );

            bundles.Add(new StyleBundle("~/Style/css").Include(
                "~/Style/updates.css")
            );
        }
    }
}