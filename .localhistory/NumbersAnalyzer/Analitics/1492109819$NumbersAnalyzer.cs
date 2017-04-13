using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumbersAnalyzer.Interfaces;
using NumbersAnalyzer.Models;

namespace NumbersAnalyzer.Analitics
{
    public class NumbersAnalyzer
    {
        public static List<string> Result { get; private set; }
        private List<SectionAux> _sectionAuxes;

        public NumbersAnalyzer()
        {
            Result = new List<string>();
        }

        public void AnalyzeSection(IDataProvider dataProvider)
        {

            var numbers = dataProvider.GetNumbers();
            var sections = dataProvider.GetSections();

        }

        private void initSectionAuxes(Sections sections)
        {
            _sectionAuxes = new List<SectionAux>();

            foreach (var section in sections.List())
            {
                
            }
        }

    }


    class SectionAux
    {
        public string Name { get; set; }
        public int Cont { get; set; }
    }
}
