using System.Collections.Generic;
using System.Linq;
using GlassPrinter.Interfaces;

namespace GlassPrinter.Builders.Martini
{
    public class MartiniGlassBuilder : IBuilder<int>
    {
        private readonly IBuilder<int> _bodyBuilder;
        private readonly IBuilder<int> _legBuilder;
        private readonly IBuilder<int> _standBuilder;

        public MartiniGlassBuilder(IBuilder<int> bodyBuilder, IBuilder<int> legBuilder, IBuilder<int> standBuilder)
        {
            _bodyBuilder = bodyBuilder;
            _legBuilder = legBuilder;
            _standBuilder = standBuilder;
        }

        public MartiniGlassBuilder() : this(new MartiniBodyBuilder(), new MartiniLegBuilder(), new MartiniStandBuilder())
        {
        }

        public IEnumerable<string> Build(int size)
        {
            return _bodyBuilder.Build(size)
                .Concat(_legBuilder.Build(size))
                .Concat(_standBuilder.Build(size));
        }

    }
}