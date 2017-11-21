namespace GlassPrinter.Statics.Beer
{
    public static class BeerGlassMetrics
    {
        public static int BodyWidth(int size)
        {
            return size;
        }

        public static int HandleWidth(int size)
        {
            return 2*size/3;
        }

        public static int Height(int size)
        {
            return 2*size;
        }
    }
}