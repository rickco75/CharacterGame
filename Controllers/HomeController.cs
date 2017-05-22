using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CharacterGame.Models;

namespace CharacterGame.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(Character.GetAll());
        }
         

        public IActionResult Create(string characterName, string characterType)
        {
            Character.Create(characterName,characterType);

            return RedirectToAction("Index");
        }





        public IActionResult About()
        {
            ViewData["Message"] = "Role Playing Adventure";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Rick Cohen";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
