using System;
using ArtOfUnitTesting2ndEd.Exercises;
using NUnit.Framework;

namespace LogAn.UnitTests
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        private LogAnalyzer MakeAnalyzer()
        {
            return new LogAnalyzer();
        }

        [Test]
        public void IsValidFileName_BadExtension_ReturnsFalse()
        {
            var analyzer = new LogAnalyzer();

            var result = analyzer.IsValidLogFileName("filewithbadextension.foo");

            Assert.False(result);
        }

        [Test]
        public void IsValidFileName_EmptyFileName_Throws()
        {
            var la = MakeAnalyzer();

            var ex = Assert.Catch<Exception>(() => la.IsValidLogFileName(""));

            StringAssert.Contains("filename has to be provivded", ex.Message);
        }

        [Test]
        public void IsValidFileName_EmptyFileName_ThrowsFluent()
        {
            var la = MakeAnalyzer();

            var ex = Assert.Catch<Exception>(() => la.IsValidLogFileName(""));

           Assert.That(ex.Message, Does.Contain("filename has to be provivded"));
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

        [Test]
        [Ignore("there is a problem with this test")]
        public void IsValidFileName_ValidFile_ReturnsTrue()
        {
        }

        [Test]
        public void IsValidFileName_WhenCalled_ChangeWasLastFileNameValid()
        {
            var la = MakeAnalyzer();

            la.IsValidLogFileName("badname.foo");

            Assert.False(la.WasLastFileNameValid);
        }
    }
}