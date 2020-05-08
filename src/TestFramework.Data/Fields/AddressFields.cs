using System.Collections.Generic;

namespace TestFramework.Data.Fields
{
    public class AddressFields : IFieldList
    {
        public virtual IEnumerable<string> Names =>
            new List<string>
            {
                "addr1",
                "addr_1",
                "address",
                "address1",
                "address_1",
            };

        public virtual IEnumerable<string> PartialNames =>
            new List<string>
            {
                "address",
                "address1",
            };
    }
}