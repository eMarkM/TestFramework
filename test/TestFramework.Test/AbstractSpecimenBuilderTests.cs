using AutoFixture;
using System.Reflection;
using Xunit;

namespace TestFramework.Test
{
    public class AbstractSpecimenBuilderTests
    {
        [Fact]
        public void Buiiler_Returns_Proper_Property_Data()
        {
            var fixture = new Fixture();
            fixture.Customizations.Add(new DataTestBuilder());

            var sut = fixture.Create<PropertyObjectToFill>();

            Assert.Equal("test", sut.Test);
            Assert.NotEqual("test", sut.NotTest);
        }

        [Fact]
        public void Buiiler_Returns_Proper_Param_Data()
        {
            var fixture = new Fixture();
            fixture.Customizations.Add(new DataTestBuilder());

            var sut = fixture.Create<ParamObjectToFill>();

            Assert.Equal("test", sut.Test);
            Assert.NotEqual("test", sut.NotTest);
        }
    }

    class PropertyObjectToFill
    {
        public string Test { get; set; }

        public string NotTest { get; set; }
    }

    class ParamObjectToFill
    {
        public ParamObjectToFill(string test, string notTest)
        {
            Test = test;
            NotTest = notTest;
        }

        public string Test { get; }

        public string NotTest { get; }
    }

    class DataTestBuilder : AbstractSpecimenBuilder
    {
        protected override object Create()
        {
            return "test";        
        }


        protected override bool MeetsCriteria(ParameterInfo parameterInfo)
        {
            return parameterInfo.Name.ToLower() == "test";
        }

        protected override bool MeetsCriteria(PropertyInfo propertyInfo)
        {
            return propertyInfo.Name.ToLower() == "test";
        }
    }

}
