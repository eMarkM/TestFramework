using TestFramework.Data.Fields;
using TestFramework.Data.Lists;

namespace TestFramework.Data.Builders
{
    public class LongTextBuilder : DataListSpecimenBuilder<string>
    {
        protected override IFieldList Fields => new LongTextFields();

        protected override IDataList<string> Data => new LoremDataList();
    }
}