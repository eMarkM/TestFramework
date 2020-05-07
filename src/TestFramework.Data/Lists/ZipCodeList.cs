using System;
using System.Collections.Generic;

namespace TestFramework.Data.Lists
{
    public class ZipCodeList : IDataList<string>
    {
        public virtual List<string> List
        {
            get
            {
                var r = new Random();
                return new List<string> {r.Next(10000, 99999).ToString()};
            }
        }
    }
}