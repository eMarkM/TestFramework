using System.Collections.Generic;

namespace TestFramework.Data.Fields
{
    public class FirstNameFields : IFieldList
    {
        public virtual IEnumerable<string> Names =>
            new List<string>
            {
                "first_name",
                "firstname",
                "fname"
            };

        public virtual IEnumerable<string> PartialNames =>
            new List<string>
            {
                "first_name",
                "firstname"
            };
    }
}