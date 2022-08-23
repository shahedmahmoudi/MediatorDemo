using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoLibrary.DataAcsess
{
    public class DemoDataAccsess:IDataAccsess
    {
        private List<PesonModel> people = new List<PesonModel>();
        public DemoDataAccsess()
        {
            people.Add(new PesonModel { Id = 1, firstName = "Timo", lastName = "Loder" });
            people.Add(new PesonModel { Id = 1, firstName = "Andrae", lastName = "Schmitt" });
        }       

        public IEnumerable<PesonModel> GetPeople()
        {
            return people;
        }

        public PesonModel InsertPeople(string firstName, string lastName)
        {
            PesonModel p = new PesonModel();
            p.firstName = firstName;
            p.lastName = lastName;
            p.Id = people.Max(x => x.Id) + 1;
            people.Add(p);
            return p;
        }
    }
}
