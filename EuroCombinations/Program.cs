using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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
            //var webRequest =
            //    WebRequest.Create(
            //        @"https://docs.google.com/spreadsheet/pub?key=0AhqMeY8ZOrNKdEFUQ3VaTHVpU29UZ3l4emFQaVZub3c&amp;output=csv");

            //var response = webRequest.GetResponse();
            //var content = response.GetResponseStream();
            //using (var reader = new StreamReader(content))
            //{
            //    var strContent = reader.ReadLine();
            //}



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

            var combAnalyze = new CombinationAnalyze(3,5);
            combAnalyze.combinationsAnalyze3(combinations);

            var orderList = combAnalyze.combinationList.OrderByDescending(x => x.Repetitions).ToList();

            var total = combAnalyze.combinationList.Sum(x => x.Repetitions);

            var maxRep = combAnalyze.combinationList.OrderByDescending(x => x.Repetitions).Take(1).FirstOrDefault();

        }



       
    }
}
