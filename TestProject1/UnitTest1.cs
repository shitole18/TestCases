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

            string name = Environment.GetEnvironmentVariable("OUTPUT_SUFFIX", EnvironmentVariableTarget.Process); 
            Assert.AreEqual("rahul", name.ToString());

        }
        [Test]
        public void Test3()
        {

            IDictionary envvars = Environment.GetEnvironmentVariables(EnvironmentVariableTarget.Process);
            foreach (dynamic item in envvars)
            {
                if (item.Key.ToUpper().ToString() == "OUTPUT_SUFFIX" || item.Key.ToLower().ToString() == "outut_suffix")
                {
                    Console.WriteLine(item.Key.ToString());
                    name = item.Key.ToString;
                }
            }
            Assert.AreEqual("rahul", name.ToString());

        }
       
    }
}