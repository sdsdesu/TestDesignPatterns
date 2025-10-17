using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPatterns.Model
{
    //builder pattern 
    public class InwonerBuilder
    {
        public string Naam { get; set; }
        public Soort Soort { get; set; }

        public IInwoner Build()
        {
           return InwonerFactory.MaakInwoner(Naam, Soort);
        }
        public InwonerBuilder SetNaam(string naam)
        {
            Naam = naam;
            return this;
        }
        public InwonerBuilder SetSoort(Soort soort)
        {
            Soort = soort;
            return this;
        }

    }
}
