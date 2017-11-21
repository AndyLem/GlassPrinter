using System.Collections.Generic;
using GlassPrinter.Interfaces;

namespace GlassPrinter.Builders
{
    public class EmptyBuilder<T> : IBuilder<T>
    {
        public IEnumerable<string> Build(T args)
        {
            yield return null;
        }
    }
}