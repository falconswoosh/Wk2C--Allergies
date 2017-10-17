using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Allergies.Models;

namespace Allergies.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
    }
}
