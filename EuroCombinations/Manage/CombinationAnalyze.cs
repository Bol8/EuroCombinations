using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EuroCombinations.POCO;

namespace EuroCombinations.Manage
{
    public class CombinationAnalyze
    {
        private  int AsociationType;
        private readonly int CombinationLength;
        public int Combinations { get; private set; }
        private int Limit;

        public List<Combination> combinationList;

        public CombinationAnalyze(int asociationType, int combinationLength)
        {
            combinationList = new List<Combination>();
            AsociationType = asociationType;
            CombinationLength = combinationLength;
            
            initValues();
        }

        private void initValues()
        {
            Limit = CombinationLength - AsociationType;
            var a = Factorial(CombinationLength);

            Limit = 1;
            var b = Factorial(AsociationType);

            Combinations = a / b;
        }



        private int Factorial(int i)
        {
            if (i <= Limit) return 1;

            return i * Factorial(i - 1);
        }


        public void combinationsAnalyze(List<List<string>> combinations)
        {
            foreach (var combination in combinations)
            {
                var list = new List<string>();
                var cont = AsociationType;

                for (int i = combination.Count - 1; i >= 0; i--)
                {
                    var a = combination[i];
                  
                    for (int j = combination.Count - cont++; j >= 0; j--)
                    {
                        var b = combination[j];

                        list.Add(a +","+ b);
                    }
                }

                if (list.Count != Combinations)
                {
                   throw new Exception("No se ha podido extraer todas las posibles combinaciones");
                }

                extractValues(list);
            }
        }


        private void extractValues(List<string> list)
        {
            foreach (var comb in list)
            {
                if (repetitionExists(comb))
                {
                    var com = combinationList.FirstOrDefault(x => x.Number.Equals(comb));
                    if (com != null) com.Repetitions++;
                }
                else
                {
                    var combination = new Combination() {Number = comb, Repetitions = 1};
                    combinationList.Add(combination);
                }
            }
        }
        
        private bool repetitionExists(string comb)
        {
            return combinationList.Exists(x => x.Number.Equals(comb));
        } 
       


    }
}
