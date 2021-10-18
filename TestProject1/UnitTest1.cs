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

            string name = Environment.GetEnvironmentVariable("FIRST_NAME", EnvironmentVariableTarget.Process); 
            Assert.AreEqual("rahul", name.ToString());

        }
        [Test]
        public void Test3()
        {

            IDictionary envvars = Environment.GetEnvironmentVariables(EnvironmentVariableTarget.Process);
            foreach (dynamic item in envvars)
            {
                if (item.Key.ToLower().ToString() == "middle_name" || item.Key.ToLower().ToString() == "MYNAME")
                {
                    Console.WriteLine(item.Key.ToString());
                    name = item.Key.ToString;
                }
            }
            Assert.AreEqual("rahul", name.ToString());

        }
        [Test]
        public void Test2()
        {

            string name = Environment.GetEnvironmentVariable("FIRST_NAME", EnvironmentVariableTarget.Process);
            IDictionary envvars = Environment.GetEnvironmentVariables(EnvironmentVariableTarget.Process);
            foreach (dynamic item in envvars)
            {
                if (item.Key.ToLower().ToString() == "MY_NAME" || item.Key.ToLower().ToString() == "MANAME")
                {
                    Console.WriteLine(item.Key.ToString());
                    name = item.Key.ToString;
                }
            }
            Assert.AreEqual("rahul", name.ToLower());

        }
    }
}