using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.AspNetCore.Mvc;
using Scrabble.Models;

namespace Scrabble.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpPost("/Results")]
    public ActionResult Results()
    {
      string userWord = Request.Form["user-word"];
      ScrabbleScore newScore = new ScrabbleScore(userWord);
      newScore.SetScore();

      return View("Results", newScore);
    }
  }
}
