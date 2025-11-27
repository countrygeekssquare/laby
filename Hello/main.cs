using System;
using HelloLib;

namespace Hello
{
    class Hello
    {
        static void Main(string[] args)
        {
            var greeter = new HelloService();
            Console.WriteLine(greeter.Greeting("world"));
        }
    }
}
