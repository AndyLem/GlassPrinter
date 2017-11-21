using System;
using System.Collections.Generic;
using GlassPrinter.Interfaces;
using GlassPrinter.Statics;
using GlassPrinter.Statics.Martini;

namespace GlassPrinter.Builders.Martini
{
    public class MartiniStandBuilder : IBuilder<int>
    {
        public IEnumerable<string> Build(int size)
        {
            if (size < 1) throw new ArgumentException(nameof(size));
            yield return new string(MartiniGlassFillers.StandFiller, MartiniGlassMetrics.StandWidth(size));
        }
    }
}