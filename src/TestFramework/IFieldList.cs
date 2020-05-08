using System.Collections.Generic;

namespace TestFramework
{
    public interface IFieldList
    {
        IEnumerable<string> Names { get; }

        IEnumerable<string> PartialNames { get; }
    }
}
