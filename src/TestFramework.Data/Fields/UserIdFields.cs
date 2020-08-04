using System.Collections.Generic;

namespace TestFramework.Data.Lists
{
    public class UserIdFields : IFieldList
    {
        public virtual IEnumerable<string> Names =>
            new List<string>
            {
                "userid",
                "login",
                "loginid",
                "userclosed",
                "createdby",
                "modifiedby",
                "updatedby",
                "callerid"
            };

        public virtual IEnumerable<string> PartialNames => new List<string>
        {
            "userid",
            "login",
            "loginid",
            "userclosed",
            "createdby",
            "modifiedby",
            "updatedby",
            "callerid"
        };
    }
}