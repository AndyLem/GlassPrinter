using GlassPrinter.Builders.Martini;
using GlassPrinter.Interfaces;

namespace GlassPrinter.Builders.Wine
{
    public class WineGlassBuilder : SimpleGlassBuilder
    {
        public WineGlassBuilder() : base(new WineBodyBuilder(), new MartiniLegBuilder(), new MartiniStandBuilder())
        {
        }
    }
}