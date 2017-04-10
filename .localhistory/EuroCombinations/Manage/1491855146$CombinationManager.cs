using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EuroCombinations.POCO;

namespace EuroCombinations.Manage
{
    public class CombinationManager
    {
        public List<CombinationEuro> Combinations { get; private set; }

        public CombinationManager(List<CombinationEuro> combinations)
        {
            Combinations = combinations;
        }
        

    }
}
