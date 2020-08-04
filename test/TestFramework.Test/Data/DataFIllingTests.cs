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

        [Theory, AutoData]
        public void Company_Data_Filled_Out(
            [Data] StandardData sut)
        {
            var list = new CompanyDataList().List;
            Assert.Contains(sut.Company, list);
        }

        [Theory, AutoData]
        public void FirstName_Data_Filled_Out(
           [Data] StandardData sut)
        {
            var list = new FirstNameDataList().List;
            Assert.Contains(sut.FirstName, list);
        }

        [Theory, AutoData]
        public void LastName_Data_Filled_Out(
           [Data] StandardData sut)
        {
            var list = new LastNameDataList().List;
            Assert.Contains(sut.LastName, list);
        }

        [Theory, AutoData]
        public void Description_Data_Filled_Out(
           [Data] StandardData sut)
        {
            var list = new LoremDataList().List;
            Assert.Contains(sut.Description, list);
        }

        [Theory, AutoData]
        public void Email_Data_Filled_Out(
           [Data] StandardData sut)
        {
            const string emailRegEx = @"[-0-9a-zA-Z.'+_]+@[-0-9a-zA-Z.+_]+\.[a-zA-Z]{2,4}";
            Assert.Matches(emailRegEx, sut.EMail);
        }

        [Theory, AutoData]
        public void Phone_Data_Filled_Out(
           [Data] StandardData sut)
        {
            int intValue = Convert.ToInt32(sut.PhoneNumber);

            Assert.True(intValue >= 1000000000);
            Assert.True(intValue <= 2000000000);
        }

        [Theory, AutoData]
        public void UserId_Data_Filled_Out(
           [Data] StandardData sut)
        {
            var list = new LastNameDataList().List;
            Assert.Contains(sut.LoginId[1..], list);
        }
    }
}
