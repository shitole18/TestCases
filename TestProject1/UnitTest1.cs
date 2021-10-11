using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        string _name = "rahul";
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            string name = Environment.GetEnvironmentVariable("MY_NAME", EnvironmentVariableTarget.Process);
            Assert.AreEqual(name, "rahul");
             
        }
    }
}