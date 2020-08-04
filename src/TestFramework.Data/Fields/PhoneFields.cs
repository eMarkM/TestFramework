using System.Collections.Generic;

namespace TestFramework.Data.Fields
{
    public class PhoneFields : IFieldList
    {
        public virtual IEnumerable<string> Names =>
            new List<string>
            {
                "phone"
            };

        public virtual IEnumerable<string> PartialNames =>
            new List<string>
            {
                "phone"                
            };
    }
}