﻿using System;
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
            const string filePath = @"C:\Users\Oscar\Documents\Ficheros\Euromillones\Historico.csv";
            

            var combinations = new List<List<string>>();

            var lines = System.IO.File.ReadAllLines(filePath);

            for (int i = 1; i < lines.Length; i++)
            {
                var numbers = lines[i].Split(',');
                var list = new List<string> {numbers[1], numbers[2], numbers[3], numbers[4], numbers[5]};
                combinations.Add(list);
            }

            var combAnalyze = new CombinationAnalyze(4,5);
            combAnalyze.combinationsAnalyze4(combinations);
            combAnalyze.rangeAnalyze(combinations);
            combAnalyze.rangeAnalyze3(combinations);

            var orderList = combAnalyze.combinationList.OrderByDescending(x => x.Repetitions).ToList();

            var comb = combAnalyze.combinationList.Where(x => x.Number.Equals("43,32,38,25"));

            var total = combAnalyze.combinationList.Sum(x => x.Repetitions);

            var maxRep = combAnalyze.combinationList.OrderByDescending(x => x.Repetitions).Take(1).FirstOrDefault();

        }



       
    }
}
