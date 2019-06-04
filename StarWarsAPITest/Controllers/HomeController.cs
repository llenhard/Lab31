﻿using StarWarsAPITest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StarWarsAPITest.Controllers
{
    public class HomeController : Controller
    {
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

        public ActionResult Person(int i)
        {
            return View(StarWarsDAL.GetPerson(i));
        }

        public ActionResult Planet(int i)
        {
            return View(StarWarsDAL.GetPlanet(i));
        }
    }
}