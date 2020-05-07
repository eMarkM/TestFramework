using AutoFixture;
using TestFramework.Data.Builders;

namespace TestFramework.Data
{
    public class StandardDataCustomizations : ICustomization
    {
        public virtual void Customize(IFixture fixture)
        {

            fixture.Customizations.Add(new AddressBuilder());
            fixture.Customizations.Add(new CityBuilder());
            fixture.Customizations.Add(new StateBuilder());
            fixture.Customizations.Add(new ZipCodeBuilder());
        }
    }
}
