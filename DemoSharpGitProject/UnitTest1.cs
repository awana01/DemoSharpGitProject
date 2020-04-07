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
            Console.WriteLine("Sample Test Execution");
            Assert.Pass();
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("TearDown Attribute");
        }
    }
}