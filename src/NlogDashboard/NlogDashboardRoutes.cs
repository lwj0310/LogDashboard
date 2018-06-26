﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NlogDashboard
{
    public static class NlogDashboardRoutes
    {
        public static RouteCollection Routes { get; }

        static NlogDashboardRoutes()
        {
            Routes = new RouteCollection();

            Routes.AddRoute(new NlogDashboardRoute("/Dashboard/Home", "Views.Dashboard.Home.cshtml"));

            Routes.AddRoute(new NlogDashboardRoute("/Dashboard/Searchlog", "Views.Dashboard.LogList.cshtml"));

            Routes.AddRoute(new NlogDashboardRoute("/Dashboard/LogInfo", "Views.Dashboard.LogInfo.cshtml"));

            Routes.AddRoute(new NlogDashboardRoute
            {
                Key = "/Dashboard/GetException",
                HtmlView = false
            });

            Routes.AddRoute(new NlogDashboardRoute("/Dashboard/Ha", "Views.Dashboard.Exception.cshtml"));
           
        }
    }
}
