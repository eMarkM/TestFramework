using AutoFixture;
using System;
using TestFramework.Data.Builders;

namespace TestFramework.Data
{
    public class StandardDataCustomizations : ICustomization
    {
        public virtual void Customize(IFixture fixture)
        {

            fixture.Customizations.Add(new AddressBuilder());
        }
    }
}
