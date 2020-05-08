using System.Collections.Generic;

namespace TestFramework
{
    public interface IDataList<TType>
    {
        List<TType> List { get; }
    }
}
