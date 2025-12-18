using HelloLib;
using NUnit.Framework;

namespace HelloTest
{
    public class HelloTest
    {
        [TestCase]
        public void GreetingTest()
        {
            var hello = new HelloService();
            var greeting = hello.Greeting("CSharp");
            Assert.That(greeting, Is.EqualTo("Hello CSharp!"));
        }

        [TestCase]
        public void GreetingDefaultTest()
        {
            var hello = new HelloService();
            var greeting = hello.Greeting();
            Assert.That(greeting, Is.EqualTo("Hello world!"));
        }
    }
}