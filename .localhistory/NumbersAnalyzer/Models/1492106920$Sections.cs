using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersAnalyzer.Models
{
    public class Sections
    {
        private readonly List<Section> _Secitons;

        public Sections()
        {
            _Secitons = new List<Section>();
        }

        public void Add(Section section)
        {
            _Secitons.Add(section);
        }

        public List<Section> List()
        {
            return _Secitons;
        }

    }
}
