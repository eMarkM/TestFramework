using System;
using System.Collections.Generic;

namespace TestFramework.Data.Lists
{
    public class PhoneList : IDataList<string>
    {
        public List<string> List => new List<string> {new Random().Next(1000000000, 2000000000).ToString()};
    }
}