using System;
using System.Collections.Generic;
using System.Text;
using GlassPrinter.Interfaces;
using GlassPrinter.Statics;
using GlassPrinter.Statics.Martini;

namespace GlassPrinter.Builders.Martini
{
    public class MartiniBodyBuilder : IBuilder<int>
    {
        public IEnumerable<string> Build(int size)
        {
            if (size < 1) throw new ArgumentException(nameof(size));
            var step = 0;
            while (step < size)
            {
                yield return BuildLine(step, size);
                step++;
            }
        }

        private string BuildLine(int step, int size)
        {
            if (step >= size) throw new ArgumentOutOfRangeException(nameof(step));

            var resultBuilder = new StringBuilder();
            resultBuilder.Append(MartiniGlassFillers.EmptyFiller, step);
            resultBuilder.Append(MartiniGlassFillers.BodyFiller, MartiniGlassMetrics.BodyWidth(size) - 2 * step);
            resultBuilder.Append(MartiniGlassFillers.EmptyFiller, step);
            return resultBuilder.ToString();
        }
    }
}