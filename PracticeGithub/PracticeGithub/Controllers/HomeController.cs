﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticeGithub.Controllers
{
    public class HomeController : Controller
    {

        public void HarisFunction1()
        {
            
            //Task 1.
            
            for(int i = 0; i < 10; i++)
            {
                //something
            }
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}