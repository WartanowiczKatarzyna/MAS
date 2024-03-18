using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS.Researcher
{
    // ekstensja klasy Researcher
    public class ResearcherExtent
    {
        private ICollection<Researcher> _researchers = new List<Researcher>();

        public void addResearcher(Researcher researcher)
        {
            _researchers.Add(researcher);
        }

        public void removeResearcher(Researcher researcher )
        {
            _researchers.Remove(researcher);
        }

        public void showResearchers()
        {
            Console.WriteLine($"Extent of the class Researcher:");
            foreach (var researcher in _researchers)
            {
                Console.WriteLine(researcher);
            }
        }
    }
}
