using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPatterns.Model
{
    public class TextAdaptor
    {
        public static List<IInwoner> LeesInwoners(string pad) {
            List<IInwoner> inwoners = new List<IInwoner>();
            foreach(var lijn in File.ReadAllLines(pad))
            {
                var delen = lijn.Split(' ');
                if (delen.Length == 2)
                {
                    char soortLetter = delen[0][0];
                    string naam = delen[1];
                    var soort = SoortAdapter.VanLetter(soortLetter);
                    inwoners.Add(InwonerFactory.MaakInwoner(naam, soort));
                }

            }
            return inwoners;

        }
    }
}
