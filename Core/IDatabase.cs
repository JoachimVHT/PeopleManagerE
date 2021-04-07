using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PeopleManagerEigen.Models;

namespace PeopleManagerEigen.Core
{
    public interface IDatabase
    {
        IList<Persoon> People { get; set; }
        void Initialize();
    }
}
