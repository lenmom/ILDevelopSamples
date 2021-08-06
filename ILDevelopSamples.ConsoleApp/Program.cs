using System;

namespace ILDevelopSamples.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IntHelper.Square(2));

            Console.WriteLine(ObjectHelper.SizeOf<int>());

            var a = 4;
            Console.WriteLine(GenericHelper.AreSame(ref a, ref a));

            Console.Read();
        }
    }
}
