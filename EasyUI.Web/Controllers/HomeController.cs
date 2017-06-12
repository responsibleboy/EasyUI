﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyUI.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TreeGridData()
        {
            string json =
                "{\"total\":9,\"rows\":[{\"id\":1,\"region\":\"Wyoming\"},{\"id\":11,\"region\":\"Albin\",\"f1\":2000,\"f2\":1800,\"f3\":1903,\"f4\":2183,\"f5\":2133,\"f6\":1923,\"f7\":2018,\"f8\":1838,\"_parentId\":1},{\"id\":12,\"region\":\"Canon\",\"f1\":2000,\"f2\":1800,\"f3\":1903,\"f4\":2183,\"f5\":2133,\"f6\":1923,\"f7\":2018,\"f8\":1838,\"_parentId\":1},{\"id\":13,\"region\":\"Egbert\",\"f1\":2000,\"f2\":1800,\"f3\":1903,\"f4\":2183,\"f5\":2133,\"f6\":1923,\"f7\":2018,\"f8\":1838,\"_parentId\":1},{\"id\":2,\"region\":\"Washington\"},{\"id\":21,\"region\":\"Bellingham\",\"f1\":2000,\"f2\":1800,\"f3\":1903,\"f4\":2183,\"f5\":2133,\"f6\":1923,\"f7\":2018,\"f8\":1838,\"_parentId\":2},{\"id\":22,\"region\":\"Chehalis\",\"f1\":2000,\"f2\":1800,\"f3\":1903,\"f4\":2183,\"f5\":2133,\"f6\":1923,\"f7\":2018,\"f8\":1838,\"_parentId\":2},{\"id\":23,\"region\":\"Ellensburg\",\"f1\":2000,\"f2\":1800,\"f3\":1903,\"f4\":2183,\"f5\":2133,\"f6\":1923,\"f7\":2018,\"f8\":1838,\"_parentId\":2},{\"id\":24,\"region\":\"Monroe\",\"f1\":2000,\"f2\":1800,\"f3\":1903,\"f4\":2183,\"f5\":2133,\"f6\":1923,\"f7\":2018,\"f8\":1838,\"_parentId\":2}],\"footer\":[{\"region\":\"Total\",\"f1\":14000,\"f2\":12600,\"f3\":13321,\"f4\":15281,\"f5\":14931,\"f6\":13461,\"f7\":14126,\"f8\":12866}]}";
            return Content(json);
        }
    }
}