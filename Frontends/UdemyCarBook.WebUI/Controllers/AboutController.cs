﻿using Microsoft.AspNetCore.Mvc;

namespace UdemyCarBook.WebUI.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Hakkımda";
            ViewBag.v2 = "Hakkımızda";
            return View();
        }
    }
}
