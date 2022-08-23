using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary.DataAcsess
{
    interface IDataAccsess
    {
        
        PesonModel InsertPeople(string firstName, string lastName);
        IEnumerable<PesonModel> GetPeople();
    }
}
