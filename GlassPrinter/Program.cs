using System;
using System.Linq;
using System.Runtime.InteropServices;
using GlassPrinter.Builders.Beer;
using GlassPrinter.Builders.Martini;
using GlassPrinter.Builders.Wine;
using GlassPrinter.Interfaces;
using GlassPrinter.Entities;

namespace GlassPrinter
{
    static class Program
    {
        static void Main(string[] args)
        {
            PrintGlass(1, GlassType.Wine);
            PrintGlass(2, GlassType.Wine);
            PrintGlass(3, GlassType.Wine);
            PrintGlass(4, GlassType.Wine);
            PrintGlass(10, GlassType.Wine);
        }

        public static void PrintGlass(int size, GlassType glassType = GlassType.Martini)
        {
            IBuilder<int> builder;
            switch (glassType)
            {
                case GlassType.Martini:
                    builder = new MartiniGlassBuilder();
                    break;
                case GlassType.Beer:
                    builder = new BeerGlassBuilder();
                    break;
                case GlassType.Wine:
                    builder = new WineGlassBuilder();
                    break;
                default:
                    builder = null;
                    break;
            }
            if (builder == null) return;
            var glass = builder.Build(size);
            foreach (var line in glass.Where(x => x != null))
                Console.WriteLine(line);
        }
    }
}
