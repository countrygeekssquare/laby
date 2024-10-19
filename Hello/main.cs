using System;
using Hello;

namespace Hello
{
    class main
    {
        static void Main(string[] args)
        {
            var greeter = new Hello();
            Console.WriteLine(greeter.Greeting());
        }
    }
}
