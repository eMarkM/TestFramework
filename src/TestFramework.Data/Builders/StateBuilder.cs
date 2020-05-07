using TestFramework.Data.Fields;
using TestFramework.Data.Lists;

namespace TestFramework.Data.Builders
{
    public class StateBuilder : DataListSpecimenBuilder<string>
    {
        protected override IFieldList Fields => new StateFields();

        protected override IDataList<string> Data => new StateDataList();
    }
}