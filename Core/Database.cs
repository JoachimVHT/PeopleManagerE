using PeopleManagerEigen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagerEigen.Core
{
    public class Database : IDatabase
    {
        public Database()
        {
            People = new List<Persoon>();
        }


        public IList<Persoon> People { get; set; }

        public void Initialize()
        {
            People = new List<Persoon>
            {
                new Persoon {Id=1, Voornaam="Joachim", Familienaam="Van haecht", Email="j.vanhaecht@gmail.com"},
                new Persoon {Id=2, Voornaam="Pol", Familienaam="hallo", Email="j.pol@gmail.com"},
                new Persoon {Id=3, Voornaam="Arthur", Familienaam="Delafontaine", Email="j.arthur@gmail.com"}
            };
        }
    }
}
