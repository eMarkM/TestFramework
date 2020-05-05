using AutoFixture.Xunit2;
using TestFramework.Data;
using TestFramework.Data.Lists;
using Xunit;

namespace TestFramework.Test.Data
{
    public class DataFIllingTests
    {
        [Theory, AutoData]
        public void Builders_Returns_Proper_Values(
            [Data] StandardData sut)
        {
            var list = new AddressDataList().List;
            var streetName = sut.Address1.Split(new[] { ' ' }, 2)[1];
            Assert.Contains(streetName, list);
        }
    }
}
