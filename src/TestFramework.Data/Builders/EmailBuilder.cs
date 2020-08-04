using TestFramework.Data.Fields;
using TestFramework.Data.Lists;

namespace TestFramework.Data.Builders
{
    public class EmailBuilder : DataListSpecimenBuilder<string>
    {
        protected override IFieldList Fields => new EmailFields();
        protected override IDataList<string> Data => new EmailList();
    }
}