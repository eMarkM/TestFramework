using TestFramework.Data.Fields;
using TestFramework.Data.Lists;

namespace TestFramework.Data.Builders
{
    public class CompanyNameBuilder : DataListSpecimenBuilder<string>
    {
        protected override IFieldList Fields => new CompanyFields();

        protected override IDataList<string> Data => new CompanyDataList();
    }
}