using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = "Hello";
            var b = "World!";
            var c = " ";
            var d = 7.5;
            var e = 5.5;
            var f = (d - e) + c + a + b;
            Console.WriteLine("Hello World!\n");
            Console.WriteLine(f);
            Console.WriteLine("\n\nTestando\n");
            for (var i =1; i<=3; ++i)
            {
                Console.WriteLine(i + "\n");
            }
            Console.WriteLine("Testando");
        }
    }
}
