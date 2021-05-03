using System;
using Humanizer;
namespace DotNetDependency
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("car".Pluralize());
            Console.WriteLine("octopus".Pluralize());
            Console.WriteLine(1003.ToWords());
        }
    }
}
