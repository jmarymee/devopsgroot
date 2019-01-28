using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            if (false)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}