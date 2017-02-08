using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace CRMProject.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundle(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/Script").Include
                (
                "~/Contents/Scripts/jquery-3.1.1.js",
                "~/Contents/Scripts/bootstrap.min.js"
                )
                );
            bundles.Add(new StyleBundle("~/bundles/Style").Include
                (
                "~/Contents/css/bootstrap.min.css"
                )
                );
        }
    }
}