using TestFramework.Data.Fields;
using TestFramework.Data.Lists;

namespace TestFramework.Data.Builders
{
    public class FirstNameBuilder : DataListSpecimenBuilder<string>
    {
        protected override IFieldList Fields => new FirstNameFields();
        protected override IDataList<string> Data => new FirstNameDataList();
    }
}