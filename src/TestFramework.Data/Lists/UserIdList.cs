using System.Collections.Generic;

namespace TestFramework.Data.Lists
{
    class UserIdList : IDataList<string>
    {
        public List<string> List
        {
            get
            {
                var list = new List<string>();

                var firstNames = new FirstNameDataList();
                var lastNames = new LastNameDataList();

                list.Add($"{firstNames.List.NextElement().Substring(0, 1)}{lastNames.List.NextElement()}");
                
                return list;
            }
        }
    }
}