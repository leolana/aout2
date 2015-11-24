using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtOfUnitTesting2ndEd.Exercises
{
    public class LogAnalyzer
    {
        public bool IsValidLogFileName(string fileName) => fileName.EndsWith(".SLF");
    }
}
