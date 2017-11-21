using System.Collections.Generic;
using System.Linq;
using GlassPrinter.Interfaces;

namespace GlassPrinter.Builders.Martini
{
    public class MartiniGlassBuilder : SimpleGlassBuilder
    {
        public MartiniGlassBuilder() : base(new MartiniBodyBuilder(), new MartiniLegBuilder(), new MartiniStandBuilder())
        {
        }
    }
}