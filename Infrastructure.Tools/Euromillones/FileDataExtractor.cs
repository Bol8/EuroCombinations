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
            var combination = new CombinationEuro()
            {
                Date = DateTime.Parse(elements[0]),
                Number1 = int.Parse(elements[1]),
                Number2 = int.Parse(elements[2]),
                Number3 = int.Parse(elements[3]),
                Number4 = int.Parse(elements[4]),
                Number5 = int.Parse(elements[5]),
                Star1 = int.Parse(elements[7]),
                Star2 = int.Parse(elements[8])
            };
            
            return combination;
        }


    }
}
