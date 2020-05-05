using System;
using TestFramework.Data.Fields;
using TestFramework.Data.Lists;

namespace TestFramework.Data.Builders
{
    public class AddressBuilder : DataListSpecimenBuilder<string>
    {
        protected override IFieldList Fields => new AddressFields();

        protected override IDataList<string> Data => new AddressDataList();

        protected override object Create()
        {
            var r = new Random();
            var streetName = base.Create();

            return $"{r.Next(1, 9999)} {streetName}";
        }
    }
}