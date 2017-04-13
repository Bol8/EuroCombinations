using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersAnalyzer.Models
{
    public class Sections
    {
        private readonly List<Section> _Sections;

        public Sections()
        {
            _Sections = new List<Section>();
        }

        public void Add(Section section)
        {
            _Sections.Add(section);
        }

        public List<Section> List()
        {
            return _Sections;
        }

    }
}
