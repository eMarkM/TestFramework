using System.Collections.Generic;

namespace TestFramework.Data.Fields
{
    public class CityFields : IFieldList
    {
        public virtual IEnumerable<string> Names =>
            new List<string>
            {
                "city"
            };

        public virtual IEnumerable<string> PartialNames =>
            new List<string>
            {
                "city"
            };
    }
}