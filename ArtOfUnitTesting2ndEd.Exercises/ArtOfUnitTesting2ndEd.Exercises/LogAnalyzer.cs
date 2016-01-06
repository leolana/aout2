using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtOfUnitTesting2ndEd.Exercises
{
    public class LogAnalyzer
    {
        public bool IsValidLogFileName(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentException("filename has to be provivded");
            }

            return fileName.EndsWith(".SLF", StringComparison.CurrentCultureIgnoreCase);
        }
    }
}
