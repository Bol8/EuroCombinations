using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EuroCombinations;
using EuroCombinations.POCO;

namespace Infrastructure.Tools.Euromillones
{
    public class FileDataExtractor:IFileDataExtractor
    {
        private readonly string[] _fileData;
        private readonly List<CombinationEuro> _combinations;


        public FileDataExtractor(string [] fileData)
        {
            _fileData = fileData;
            _combinations = extractDataFromFile();
        }

        public List<CombinationEuro> getCombinations()
        {
            return _combinations;
        }


        private List<CombinationEuro> extractDataFromFile()
        {
            var list = new List<CombinationEuro>();

            for (int i = 1; i < _fileData.Length; i++)
            {
                var row = _fileData[i];
                list.Add(extractCombinationFromRow(row));
            }


            return list;
        }


        private CombinationEuro extractCombinationFromRow(string row)
        {
            var elements = row.Split(',');
            
            return null;
        }


    }
}
