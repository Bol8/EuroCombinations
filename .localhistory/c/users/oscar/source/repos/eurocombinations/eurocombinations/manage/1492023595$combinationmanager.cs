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

        public CombinationManager(IFileDataExtractor fileDataExtractor)
        {
            Combinations = fileDataExtractor.getCombinations();
        }


        public List<EuroPattern> getPatterns()
        {

            foreach (var combination in Combinations)
            {
                
            }


            return null;
        }





    }
}
