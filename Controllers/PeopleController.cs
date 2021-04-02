using Microsoft.AspNetCore.Mvc;
using PeopleManagerEigen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagerEigen.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Index()
        {
            var people = GetPeople();
            return View(people);
        }

        public IList<Persoon> GetPeople()
        {
            return new List<Persoon>
            {
                new Persoon {Id=1, Voornaam="Joachim", Familienaam="Van haecht", Email="j.vanhaecht@gmail.com"},
                new Persoon {Id=2, Voornaam="Pol", Familienaam="hallo", Email="j.vanhaecht@gmail.com"},
                new Persoon {Id=3, Voornaam="Arthur", Familienaam="Delafontaine", Email="j.vanhaecht@gmail.com"}
            };
        }
    }
}
