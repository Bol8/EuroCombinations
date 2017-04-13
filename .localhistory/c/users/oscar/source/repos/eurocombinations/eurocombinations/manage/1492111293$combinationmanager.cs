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
            var patterns = new List<EuroPattern>();

            foreach (var combination in Combinations)
            {
                var pattern = extractPattern(combination);

                if (!patterns.Exists(x => Equals(x.Pattern, pattern.Pattern)))
                {
                    patterns.Add(pattern);
                }
            }

            return patterns;
        }


        private EuroPattern extractPattern(CombinationEuro combination)
        {
            var patternFormat = "{0},{1},{2},{3},{4}";
            var num2 = combination.Number2 - combination.Number1;
            var num3 = combination.Number3 - combination.Number2;
            var num4 = combination.Number4 - combination.Number3;
            var num5 = combination.Number5 - combination.Number4;

            
            var pattern = new EuroPattern()
            {
                Number1 = combination.Number1,
                Number2 = num2,
                Number3 = num3,
                Number4 = num4,
                Number5 = num5,
                Pattern = String.Format(patternFormat, combination.Number1,num2,num3,num4,num5)
                
            };
            
            return pattern;
        }


    }
}
