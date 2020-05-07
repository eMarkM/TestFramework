using System.Collections.Generic;

namespace TestFramework.Data.Fields
{
    class LongTextFields : IFieldList
    {
        public virtual IEnumerable<string> Names =>
            new List<string>
            {
                "description",
                "notes"
            };

        public virtual IEnumerable<string> PartialNames =>
            new List<string>
            {
                "description",
                "comments",
                "text",
                "notes"
            };
    }
}