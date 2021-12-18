using NUnit.Framework;

namespace NunitSample
{
    public class Tests
    {
        public int add()
        {
            int x = a + b;
            return 0;
        }
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}