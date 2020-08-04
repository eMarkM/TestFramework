using System.Collections.Generic;
using TestFramework;


namespace TestFramework.Data.Lists
{
    public class EmailList : IDataList<string>
    {
        public List<string> List
        {
            get
            {
                var list = new List<string>();

                var firstNames = new FirstNameDataList();
                var lastNames = new LastNameDataList();
                var companyData = new CompanyDataList();

                var companyName = companyData.List.NextElement().Replace(" ", string.Empty);
                list.Add($"{firstNames.List.NextElement().Substring(0, 1)}{lastNames.List.NextElement()}@{companyName}.com");
                
                return list;
            }
        }
    }
}