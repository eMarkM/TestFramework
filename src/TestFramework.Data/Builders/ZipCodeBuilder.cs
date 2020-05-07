using TestFramework.Data.Fields;
using TestFramework.Data.Lists;

namespace TestFramework.Data.Builders
{
    public class ZipCodeBuilder : DataListSpecimenBuilder<string>
    {
        protected override IFieldList Fields => new ZipCodeFields();

        protected override IDataList<string> Data => new ZipCodeList();
    }
}