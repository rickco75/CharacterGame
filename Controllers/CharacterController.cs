﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;


using CharacterGame.Models;

namespace CharacterGame.Controllers
{
    public class CharacterController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CharacterController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var model = _context.Characters.ToList();
            return View(model);
        }

        public IActionResult GetActive()
        {
            var model = _context.Characters.Where(e => e.IsActive).ToList();
            return View(model);

        }

        public IActionResult Details(string name)
        {
            var model = _context.Characters.FirstOrDefault(e => e.Name == name);
            return View(model);
        }

        public IActionResult Update(Character character)
        {
            _context.Entry(character).State = EntityState.Modified;
            _context.SaveChanges();
            
            return RedirectToAction("Index");
        }

        public IActionResult Delete(string name)
        {
            var original = _context.Characters.FirstOrDefault(e => e.Name == name);
            if (original != null)
            {
                _context.Characters.Remove(original);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Create(Character character)
        {
            _context.Characters.Add(character);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
