using TestFramework.Data.Fields;
using TestFramework.Data.Lists;

namespace TestFramework.Data.Builders
{
    public class LastNameBuilder : DataListSpecimenBuilder<string>
    {
        protected override IFieldList Fields => new LastNameFields();
        protected override IDataList<string> Data => new LastNameDataList();

    }
}