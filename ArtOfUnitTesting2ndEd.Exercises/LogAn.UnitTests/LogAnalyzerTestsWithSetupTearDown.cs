using ArtOfUnitTesting2ndEd.Exercises;
using NUnit.Framework;

namespace LogAn.UnitTests
{
    [TestFixture]
    public class LogAnalyzerTestsWithSetUpTearDown
    {
        private LogAnalyzer analyzer = null;

        [SetUp]
        public void Setup()
        {
            analyzer = new LogAnalyzer();
        }

        [Test]
        public void IsValidFileName_ValidFileLowerCase_ReturnsTrue()
        {
            var result = analyzer.IsValidLogFileName("filewithbadextension.slf");

            Assert.IsTrue(result, "filename should be valid!");
        }

        [Test]
        public void IsValidFileName_ValidFileUpperCase_ReturnsTrue()
        {
            var result = analyzer.IsValidLogFileName("filewithbadextension.SLF");

            Assert.IsTrue(result, "filename should be valid!");
        }

        [TearDown]
        public void TearDown()
        {
            analyzer = null; //Don't do it in real life.
        }
    }
}