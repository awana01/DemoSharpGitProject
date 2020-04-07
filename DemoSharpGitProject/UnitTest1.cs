using System;
using NUnit.Framework;

namespace DemoSharpGitProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup Attribute");
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine($"Sample Test Execution {TestContext.CurrentContext.Test.Name}");
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            Console.WriteLine($"Sample Test Execution {TestContext.CurrentContext.Test.Name}");
            Assert.Pass();
        }


        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("TearDown Attribute");
        }
    }
}