using System;
using GlassPrinter.Builders.Martini;

namespace GlassPrinter
{
    static class Program
    {
        static void Main(string[] args)
        {
            PrintGlass(1);
            PrintGlass(2);
            PrintGlass(3);
            PrintGlass(4);
        }

        public static void PrintGlass(int size)
        {
            var builder = new MartiniGlassBuilder();
            var glass = builder.Build(size);
            foreach (var line in glass)
                Console.WriteLine(line);
        }
    }
}
