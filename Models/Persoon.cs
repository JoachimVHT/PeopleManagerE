using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleManagerEigen.Models
{
    public class Persoon
    {
        public int Id { get; set; }
        public string Voornaam { get; set; }
        public string Familienaam { get; set; }
        public string Email { get; set; }
        //public DateTime Inschrijvingsdatum { get; set; }
    }
}
