using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary.DataAcsess
{
  public  interface IDataAccsess
    {
        
        PesonModel InsertPeople(string firstName, string lastName);
        List<PesonModel> GetPeople();
    }
}
