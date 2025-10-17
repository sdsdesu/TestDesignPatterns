using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPatterns.Model
{
    // Adapter pattern
    public static class SoortAdapter
    {
        public static char NaarLetter(Soort soort)
        {
            return soort switch
            {
                Soort.Vogel => 'V',
                Soort.Zoogdier => 'Z',
                _ => '?'
            };
        }

        public static Soort VanLetter(char letter)
        {
            return letter switch
            {
                'V' => Soort.Vogel,
                'Z' => Soort.Zoogdier,
                _ => throw new ArgumentException("Onbekende letter")
            };
        }
    }
}
