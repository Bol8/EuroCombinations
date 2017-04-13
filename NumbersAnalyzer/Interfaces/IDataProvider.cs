using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumbersAnalyzer.Models;

namespace NumbersAnalyzer.Interfaces
{
    public interface IDataProvider
    {
        List<int> GetNumbers();
        Sections GetSections();
    }
}
