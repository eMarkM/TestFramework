using System.Collections.Generic;

namespace TestFramework.Data.Fields
{
    public class LastNameFields : IFieldList
    {
        public virtual IEnumerable<string> Names =>
            new List<string>
            {
                "last_name",
                "lastname",
                "lname",
            };

        public virtual IEnumerable<string> PartialNames =>
            new List<string>
            {
                "last_name",
                "lastname"
            };
    }
}