using AutoFixture.Xunit2;
using Moq;
using TestFramework.Moq;
using Xunit;

namespace TestFramework.Test.Moq
{
    public class AutoMoqDataAttributeTests
    {
        [Theory, AutoMoqData]
        public void AutoMoqData_Injects_Frozen_Mocked_Interface(
            [Frozen] Mock<IMockMe> mockedInterface,
            InjectedWithMockMe sut)
        {
            const string expected = "stuff";
            mockedInterface.Setup(mi => mi.GetSomeString())
                .Returns(expected);

            var result = sut.GetFromMoqMe();

            Assert.Equal(expected, result);
        }        
    }
}
