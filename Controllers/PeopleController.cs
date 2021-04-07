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
    }
}
