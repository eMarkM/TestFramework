using System.Collections.Generic;

namespace TestFramework.Data.Fields
{
    public class StateFields : IFieldList
    {
        public virtual IEnumerable<string> Names =>
            new List<string>
            {
                "state",
                "st"
            };

        public virtual IEnumerable<string> PartialNames =>
            new List<string>
            {
                "state"
            };
    }
}