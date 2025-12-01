using HelloLib;
using Xunit;

namespace HelloTest
{
    public class HelloTest
    {
        [Fact]
        public void greetingTest()
        {
            var hello = new HelloService();
            var greeting = hello.Greeting("CSharp");
            Assert.Equal("Hello CSharp!", greeting);
        }

        [Fact]
        public void greetingDefaultTest()
        {
            var hello = new HelloService();
            var greeting = hello.Greeting();
            Assert.Equal("Hello world!", greeting);
        }
    }
}