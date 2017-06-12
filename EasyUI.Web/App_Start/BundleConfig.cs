using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace EasyUI.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/easyui/js").Include(
                "~/jquery-easyui/jquery.min.js",
                "~/jquery-easyui/jquery.easyui.min.js",
                "~/jquery-easyui/locale/easyui-lang-zh_CN.js"));
            bundles.Add(new StyleBundle("~/easyui/css").Include(
                "~/jquery-easyui/themes/bootstrap/easyui.css",
                "~/jquery-easyui/themes/icon.css",
                "~/jquery-easyui/themes/color.css"));
        }
    }
}