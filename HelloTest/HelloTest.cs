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
            var greeting = hello.Greeting("World");
            Assert.Equal("Hello World!", greeting);
        }
    }
}