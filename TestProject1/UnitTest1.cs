using NUnit.Framework;
using System;
using System.Collections;

namespace TestProject1
{
    public class Tests
    {
        string name = "rahul";
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {

            string name = Environment.GetEnvironmentVariable("MY_NAME", EnvironmentVariableTarget.Process);
            IDictionary envvars = Environment.GetEnvironmentVariables(EnvironmentVariableTarget.Process);
            foreach (dynamic item in envvars)
            {
                if (item.Key.ToString == "MY_NAME" || item.Key == "MYNAME" || item.Key == "MYNAME")
                {
                    Console.WriteLine(item.Key.ToString);
                    name = item.Key.ToString;
                }
            }
            Assert.AreEqual("rahul", name);

        }
    }
}