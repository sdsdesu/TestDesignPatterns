using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPatterns.Model
{
    //Factory pattern 
    public static class InwonerFactory
    {
        public static IInwoner MaakInwoner(string naam, Soort soort)
        {
            return soort switch
            {
                Soort.Vogel => new Vogel(naam),
                Soort.Zoogdier => new Zoogdier(naam),
                _ => throw new ArgumentException("Onbekend soort"),
            };
        }
    }
}
