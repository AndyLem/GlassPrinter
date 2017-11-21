using System.Collections.Generic;

namespace GlassPrinter.Interfaces
{
    public interface IBuilder<in T>
    {
        IEnumerable<string> Build(T args);
    }
}