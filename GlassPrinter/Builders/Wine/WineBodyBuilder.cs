using System;
using System.Collections.Generic;
using System.Text;
using GlassPrinter.Interfaces;
using GlassPrinter.Statics.Martini;

namespace GlassPrinter.Builders.Wine
{
    public class WineBodyBuilder : IBuilder<int>
    {
        public IEnumerable<string> Build(int height)
        {
            if (height < 1) throw new ArgumentException(nameof(height));
            var step = 0;
            while (step < height)
            {
                yield return BuildLine(step, height);
                step++;
            }
        }

        private string BuildLine(int step, int height)
        {
            var angle = step * (Math.PI / 2) / (height + 1);
            var len = (int)(height * Math.Cos(angle));
            if (len < 1) len = 1;
            return BuildLineByLength(len*2, height*2+1);
        }

        private string BuildLineByLength(int length, int width)
        {
            if (length > width) throw new ArgumentOutOfRangeException(nameof(length));
            var emptySize = (width - length) / 2;
            var resultBuilder = new StringBuilder();
            resultBuilder.Append(MartiniGlassFillers.EmptyFiller, emptySize);
            resultBuilder.Append(MartiniGlassFillers.BodyFiller, width - 2 * emptySize);
            resultBuilder.Append(MartiniGlassFillers.EmptyFiller, emptySize);
            return resultBuilder.ToString();
        }
    }
}