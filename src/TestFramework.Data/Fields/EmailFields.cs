using System.Collections.Generic;

namespace TestFramework.Data.Fields
{
    class EmailFields : IFieldList
    {
        public virtual IEnumerable<string> Names =>
            new List<string>
            {
                "email"
            };

        public virtual IEnumerable<string> PartialNames =>
            new List<string>
            {
                "email"
            };
    }
}