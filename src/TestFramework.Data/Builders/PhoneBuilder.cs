using TestFramework.Data.Fields;
using TestFramework.Data.Lists;

namespace TestFramework.Data.Builders
{
    public class PhoneBuilder : DataListSpecimenBuilder<string>
    {
        protected override IFieldList Fields => new PhoneFields();
        protected override IDataList<string> Data => new PhoneList();
    }
}