using CSharpPattern.Facade.Entities;
using System;

namespace CSharpPattern.Facade.Components
{
    public class Data
    {
        public bool InsertPersonalData(Person person) { return person.Equals(null); }

        public void DataFailed() { Console.WriteLine("Fail to save data."); }

    }
}
