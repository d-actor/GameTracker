using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GameTracker.Models;

namespace GameTracker.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      return View(Models.Character.GetAll());
    }

    public IActionResult Create(string characterName)
    {
      Models.Character.Create(characterName);
      return RedirectToAction("Index");
      // var model = new GameTracker.Models.Character();
      // model.Name = characterName;
      // return View("Index", model);
    }

// TODO make destroy action

    public IActionResult About()
    {
      ViewData["Message"] = "Game Tracker Application description page.";

      return View();
    }

    public IActionResult Contact()
    {
      ViewData["Message"] = "Dan's contact page.";

      return View();
    }

    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
