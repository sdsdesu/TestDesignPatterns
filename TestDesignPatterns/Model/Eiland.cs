using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPatterns.Model
{
    public class Eiland
    {
        public List<IInwoner> Inwoners { get; set; } = new List<IInwoner>();
        //verouderde manier om inwoners toe te voegen
        public void VoegInwonerToe(string naam, Soort soort)
        {
            Inwoners.Add(new InwonerBuilder().SetNaam(naam).SetSoort(soort).Build());
        }


        public void GeefInwonersWeer()
        {
            foreach (var inwoner in Inwoners)
            {
                Console.WriteLine(inwoner.WeergevenInfo);
            }
        }

        public void Vulkaanuibarsting()
        {
            Console.WriteLine("De vulkaan barst uit!");
            foreach (var inwoner in Inwoners)
                inwoner.Update("Vulkaanuibarsting");
        }


    }
}
