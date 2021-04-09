using Microsoft.AspNetCore.Mvc;
using PeopleManagerEigen.Core;
using PeopleManagerEigen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagerEigen.Controllers
{
    public class PeopleController : Controller
    {
        private readonly IDatabase _database;

        public PeopleController(IDatabase database)
        {
            _database = database;
        }
        public IActionResult Index()
        {
            var people = GetPeople();
            return View(people);
        }

        public IList<Persoon> GetPeople()
        {
            return _database.People;
        }

        

        [HttpGet]
        public IActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Persoon persoon)
        {
            persoon.Id = GetNewId();
            
            _database.People.Add(persoon);

            return RedirectToAction("Index");
        }

        private int GetNewId()
        {
            if (_database.People.Any())
            {
                var getMaxId = _database.People.Max(p => p.Id);
                return getMaxId += 1;
            }
            else
            {
                return 1;
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var gezochtePers = _database.People.SingleOrDefault(p => p.Id == id);
            if(gezochtePers == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(gezochtePers);
            }

            
        }

        [HttpPost]
        public IActionResult Edit(Persoon persoon)
        {
            var pers = _database.People.SingleOrDefault(p => p.Id == persoon.Id);

            if(pers != null)
            {
                pers.Email = persoon.Email;
                pers.Familienaam = persoon.Familienaam;
                pers.Voornaam = persoon.Voornaam;
            }
           
            return RedirectToAction("Index");

        }
        

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var pers = _database.People.SingleOrDefault(p => p.Id == id);
            if (pers != null)
            {
                return View(pers);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Delete(Persoon persoon)
        {
            var pers = _database.People.SingleOrDefault(p => p.Id == persoon.Id);
            if(pers != null)
            {
                _database.People.Remove(pers);
            }
            return RedirectToAction("Index");

        }
    }
}
