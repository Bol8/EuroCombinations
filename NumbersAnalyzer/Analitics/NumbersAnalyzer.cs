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

        public void AnalyzeNumbers(IDataProvider dataProvider)
        {
            var numbers = dataProvider.GetNumbers();
            var sections = dataProvider.GetSections();
            initSectionAuxes(sections);

            foreach (var number in numbers)
            {
                var section = getSection(number, sections);
                recount(section);
            }
        }

        private void initSectionAuxes(Sections sections)
        {
            _sectionAuxes = new List<SectionAux>();

            foreach (var section in sections.List())
            {
                var sectionAux = new SectionAux()
                {
                    Name =  section.Name,
                    Cont = 0
                };

                _sectionAuxes.Add(sectionAux);
            }
        }

        private Section getSection(int number, Sections sections)
        {
            foreach (var section in sections.List())
            {
                if (isBetweenNumbers(section.From, section.To, number))
                {
                    return section;
                }
            }

            return null;
        }

        private bool isBetweenNumbers(int from, int to, int number)
        {
            return (number >= from && number < to);
        }

        private void recount(Section section)
        {
            var sectionAux = _sectionAuxes.Find(x => Equals(section.Name, x.Name));
            sectionAux.Cont++;
        }
    }


    class SectionAux
    {
        public string Name { get; set; }
        public int Cont { get; set; }
    }
}
