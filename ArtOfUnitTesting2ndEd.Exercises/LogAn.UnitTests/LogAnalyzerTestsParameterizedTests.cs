using ArtOfUnitTesting2ndEd.Exercises;
using NUnit.Framework;

namespace LogAn.UnitTests
{
    [TestFixture]
    public class LogAnalyzerTestsParameterizedTests
    {
        [TestCase("filewithbadextension.foo", false)]
        [TestCase("filewithbadextension.slf", true)]
        [TestCase("filewithbadextension.SLF", true)]
        public void IsValidFileName_ValidExtensions_ReturnsTrue(string file, bool expected)
        {
            var analyzer = new LogAnalyzer();

            var result = analyzer.IsValidLogFileName(file);

            Assert.AreEqual(expected, result);
        }
    }
}