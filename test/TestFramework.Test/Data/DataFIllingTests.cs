using AutoFixture.Xunit2;
using System;
using TestFramework.Data;
using TestFramework.Data.Lists;
using Xunit;

namespace TestFramework.Test.Data
{
    public class DataFIllingTests
    {
        [Theory, AutoData]
        public void Address_Data_Filled_Out(
            [Data] StandardData sut)
        {
            var list = new AddressDataList().List;
            var streetName = sut.Address1.Split(new[] { ' ' }, 2)[1];
            Assert.Contains(streetName, list);
        }

        [Theory, AutoData]
        public void City_Data_Filled_Out(
            [Data] StandardData sut)
        {         
            var list = new CityDataList().List;
            Assert.Contains(sut.City, list);
        }

        [Theory, AutoData]
        public void State_Data_Filled_Out(
            [Data] StandardData sut)
        {
            var list = new StateDataList().List;
            Assert.Contains(sut.State, list);
        }

        [Theory, AutoData]
        public void Zip_Data_Filled_Out(
          [Data] StandardData sut)
        {
            int zipAsInt = Convert.ToInt32(sut.ZipCode);
            Assert.InRange(zipAsInt, 10000, 99999);
        }
    }
}
