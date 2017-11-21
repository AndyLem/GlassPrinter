namespace GlassPrinter.Statics.Martini
{
    public static class MartiniGlassMetrics
    {
        public static int BodyWidth(int size)
        {
            return 2*size - 1;
        }

        public static int StandWidth(int size)
        {
            return BodyWidth(size);
        }

        public static int LegLength(int size)
        {
            return size;
        }
    }
}