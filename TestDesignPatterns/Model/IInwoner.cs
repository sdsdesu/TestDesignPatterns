using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignPatterns.Model
{
    //Observer pattern
    public interface IInwoner
    {
        public string Naam { get; }
        public Soort Soort { get; }
        public string WeergevenInfo=> $"{SoortAdapter.NaarLetter(Soort)} {Naam}";

        void Update(string gebeurtenis);

    }
}
