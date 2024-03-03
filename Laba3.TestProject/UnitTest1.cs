using Laba3.ClassLibrary;

namespace Laba3.TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddTestSquare()
        {
            const double r = 2;
            const double R = 4;
            const double l = 3;
            const double expected = 56.548667764616276;

            double result = new ClassSquare().S(r, R, l);
            Assert.AreEqual(expected, result);

        }
    }
}