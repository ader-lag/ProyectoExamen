﻿using System.Web;
using System.Web.Optimization;

namespace ProyectoVotaciones
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Content/Homecss").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/DocumentCss/HomePage.css"));
            bundles.Add(new StyleBundle("~/Content/PageStylecss").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/DocumentCss/PageStyleVote.css"));
        }
    }
}
