using System.Collections.Generic;

namespace TestFramework.Data.Fields
{
    public class ZipCodeFields : IFieldList
    {
        public virtual IEnumerable<string> Names =>
            new List<string>
            {
                "zip",
                "zip_code",
                "postalcode",
                "postal_code",
                "zipcode"
            };

        public virtual IEnumerable<string> PartialNames =>
            new List<string>
            {
                "zipcode",
                "zip_code",
                "postalcode",
                "postal_code"
            };
    }
}