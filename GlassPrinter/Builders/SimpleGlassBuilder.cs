using System.Collections.Generic;
using System.Linq;
using GlassPrinter.Interfaces;

namespace GlassPrinter.Builders
{
    public class SimpleGlassBuilder : IBuilder<int>
    {
        private readonly IBuilder<int> _bodyBuilder;
        private readonly IBuilder<int> _legBuilder;
        private readonly IBuilder<int> _standBuilder;

        public SimpleGlassBuilder(IBuilder<int> bodyBuilder, IBuilder<int> legBuilder, IBuilder<int> standBuilder)
        {
            _bodyBuilder = bodyBuilder;
            _legBuilder = legBuilder;
            _standBuilder = standBuilder;
        }

        public IEnumerable<string> Build(int size)
        {
            return _bodyBuilder.Build(size)
                .Concat(_legBuilder.Build(size))
                .Concat(_standBuilder.Build(size));
        }
    }
}