using AutoFixture;
using AutoFixture.Xunit2;
using System.Reflection;

namespace TestFramework.Data
{
    /// <summary>
    /// Fill in objects with realistic test data.
    /// </summary>
    public class DataAttribute : CustomizeAttribute
    {
        public override ICustomization GetCustomization(ParameterInfo parameter)
        {
            return new StandardDataCustomizations();
        }
    }
}
