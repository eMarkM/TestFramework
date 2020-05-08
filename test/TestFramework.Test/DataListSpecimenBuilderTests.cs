using AutoFixture;
using System.Collections.Generic;
using Xunit;

namespace TestFramework.Test
{
    public class DataListSpecimenBuilderTests
    {
        public static List<string> TestValues = new List<string> { "one", "two", "three" };

        [Fact]
        public void Data_Filled_From_TestValues()
        {
            var fixture = new Fixture();
            fixture.Customizations.Add(new TestDataListBuilder());

            var sut = fixture.Create<PropertyObjectToFill>();

            Assert.Contains(sut.Test, TestValues);
            Assert.DoesNotContain(sut.SomethingElse, TestValues);
        }
    }

    class TestDataListBuilder : DataListSpecimenBuilder<string>
    {
        protected override IFieldList Fields => new TestFields();

        protected override IDataList<string> Data => new TestData();
    }

    class TestFields : IFieldList
    {
        public IEnumerable<string> Names => new List<string> { "test" };

        public IEnumerable<string> PartialNames => new List<string> { "test" };
    }

    class TestData : IDataList<string>
    {
        public List<string> List => DataListSpecimenBuilderTests.TestValues;
    }
}
