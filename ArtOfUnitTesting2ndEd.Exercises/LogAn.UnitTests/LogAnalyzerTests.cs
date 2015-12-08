using ArtOfUnitTesting2ndEd.Exercises;
using NUnit.Framework;

namespace LogAn.UnitTests
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [Test]
        public void IsValidFileName_BadExtension_ReturnsFalse()
        {
            var analyzer = new LogAnalyzer();

            var result = analyzer.IsValidLogFileName("filewithbadextension.foo");

            Assert.False(result);
        }

        [Test]
        public void IsValidFileName_GoodExtensionLowerCase_ReturnsTrue()
        {
            var analyzer = new LogAnalyzer();

            var result = analyzer.IsValidLogFileName("filewithbadextension.slf");

            Assert.True(result);
        }


        [Test]
        public void IsValidFileName_GoodExtensionUpperCase_ReturnsTrue()
        {
            var analyzer = new LogAnalyzer();

            var result = analyzer.IsValidLogFileName("filewithbadextension.SLF");

            Assert.True(result);
        }
    }
}