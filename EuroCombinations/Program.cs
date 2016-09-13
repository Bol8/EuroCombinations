using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EuroCombinations.Manage;
using EuroCombinations.POCO;

namespace EuroCombinations
{
    class Program
    {
        static int limit;
        static void Main(string[] args)
        {
            const string filePath = @"C:\Users\Oscar\Documents\Ficheros\Euromillones\Historico.csv";
            
           // var combinations = new List<Combination>();

            var combinations = new List<List<string>>();

            var lines = System.IO.File.ReadAllLines(filePath);

            for (int i = 1; i < lines.Length; i++)
            {
                var numbers = lines[i].Split(',');
                var list = new List<string> {numbers[1], numbers[2], numbers[3], numbers[4], numbers[5]};
                combinations.Add(list);
                
            }

            var combAnalyze = new CombinationAnalyze(2,5);
            combAnalyze.combinationsAnalyze(combinations);

            var orderList = combAnalyze.combinationList.OrderByDescending(x => x.Repetitions).ToList();

            var maxRep = combAnalyze.combinationList.OrderByDescending(x => x.Repetitions).Take(1).FirstOrDefault();

        }



       
    }
}
