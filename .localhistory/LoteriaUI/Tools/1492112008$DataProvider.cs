using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumbersAnalyzer.Interfaces;
using NumbersAnalyzer.Models;

namespace LoteriaUI.Tools
{
    public class DataProvider:IDataProvider
    {
        private List<int> _numbers;
        private Sections _sections;

        public DataProvider(List<int> numbers, Sections sections)
        {
            _numbers = numbers;
            _sections = sections;
        }


        public List<int> GetNumbers()
        {
            return _numbers;
        }

        public Sections GetSections()
        {
            return _sections;
        }
    }
}
