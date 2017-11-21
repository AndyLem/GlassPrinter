namespace GlassPrinter.Builders.Beer
{
    public class BeerGlassBuilder : SimpleGlassBuilder
    {
        public BeerGlassBuilder() : base(new BeerBodyBuilder(), new EmptyBuilder<int>(), new EmptyBuilder<int>())
        {
        }
    }
}