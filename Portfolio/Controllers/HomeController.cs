﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        //public IActionResult HelloAjax()
        //{
        //    return Content("This is a test!", "text/plain");
        //}

        public PartialViewResult GetMyInfo()
        {
            return PartialView("_MoreAboutMe");
        }

        public PartialViewResult GetJobExperience()
        {
            return PartialView("_JobExperience");
        }

        public IActionResult CloseIt()
        {
            return Content("", "text/plain");
        }
    }
}
