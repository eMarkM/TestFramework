using TestFramework.Data.Fields;
using TestFramework.Data.Lists;

namespace TestFramework.Data.Builders
{
    public class CityBuilder : DataListSpecimenBuilder<string>
    {
        protected override IFieldList Fields => new CityFields();
        protected override IDataList<string> Data => new CityDataList();
    }
}
