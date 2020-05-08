using System.Collections.Generic;

namespace TestFramework.Data.Fields
{
    public class CompanyFields : IFieldList
    {
        public virtual IEnumerable<string> Names =>
            new List<string>
            {
                "company",
                "companyname",
                "client",
                "clientname",
                "business",
                "businessname"
            };

        public virtual IEnumerable<string> PartialNames => new List<string>
        {
            "company",
            "business",
            "facility"
        };
    }
}