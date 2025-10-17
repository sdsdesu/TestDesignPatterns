using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPatterns.Model
{
    public class Zoogdier : IInwoner
    {
        public string Naam { get; }

        public Soort Soort => Soort.Zoogdier;

        public Zoogdier(String naam)
        {
            Naam = naam;
        }
        public void Update(string gebeurtenis)
        {
            if (gebeurtenis == "Vulkaanuibarsting")
                Console.WriteLine($"{Naam} schuilt in zijn hol!");
        }
    }
}
