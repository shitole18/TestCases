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
         public void Test2()
        {
            string name = Environment.GetEnvironmentVariable("FIRST_NAME", EnvironmentVariableTarget.Process); 
            Assert.AreEqual("rahul", name.ToString());
        }
    }
}