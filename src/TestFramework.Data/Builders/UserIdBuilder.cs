using TestFramework.Data.Lists;

namespace TestFramework.Data.Builders
{
    public class UserIdBuilder : DataListSpecimenBuilder<string>
    {
        protected override IFieldList Fields => new UserIdFields();
        protected override IDataList<string> Data => new UserIdList();
    }
}
