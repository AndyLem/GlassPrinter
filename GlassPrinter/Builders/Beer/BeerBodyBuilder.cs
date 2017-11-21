using System;
using System.Collections.Generic;
using GlassPrinter.Interfaces;
using GlassPrinter.Statics.Beer;

namespace GlassPrinter.Builders.Beer
{
    public class BeerBodyBuilder : IBuilder<int>
    {
        public IEnumerable<string> Build(int size)
        {
            if (size < 1) throw new ArgumentException(nameof(size));

            var step = 0;
            while (step < size)
            {
                yield return BuildLine(step, size) + (BuildHandle(step, size));
                step++;
            }
        }

        private string BuildHandle(int step, int size)
        {
            if (step == 0 || step == size - 1) return string.Empty;
            if (step == 1 || step == size - 2)
                return new string(BeerGlassFillers.HandleBarFiller, BeerGlassMetrics.HandleWidth(size) - 1);
            return new string(BeerGlassFillers.EmptyFiller, BeerGlassMetrics.HandleWidth(size) - 1) +
                   BeerGlassFillers.HandleFiller;
        }

        private string BuildLine(int step, int size)
        {
            if (step == size - 1)
                return BeerGlassFillers.EmptyFiller +
                       new string(BeerGlassFillers.BodyFiller, BeerGlassMetrics.BodyWidth(size) - 2) +
                       BeerGlassFillers.EmptyFiller;
            return new string(BeerGlassFillers.BodyFiller, BeerGlassMetrics.BodyWidth(size));
        }
    }
}