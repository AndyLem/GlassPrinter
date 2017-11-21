using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GlassPrinter.Interfaces;
using GlassPrinter.Statics;
using GlassPrinter.Statics.Martini;

namespace GlassPrinter.Builders.Martini
{
    public class MartiniLegBuilder : IBuilder<int>
    {
        public IEnumerable<string> Build(int size)
        {
            if (size < 1) throw new ArgumentException(nameof(size));
            
            var emptySpace = (MartiniGlassMetrics.StandWidth(size) - 1) / 2;
            return Enumerable.Repeat(BuildLine(emptySpace), MartiniGlassMetrics.LegLength(size));
        }

        private string BuildLine(int emptySpace)
        {
            var emptyString = new string(MartiniGlassFillers.EmptyFiller, emptySpace);
            return emptyString + MartiniGlassFillers.LegFiller + emptyString;

        }
    }
}