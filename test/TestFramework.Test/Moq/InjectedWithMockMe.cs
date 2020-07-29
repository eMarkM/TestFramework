namespace TestFramework.Test.Moq
{
    public class InjectedWithMockMe
    {
        private readonly IMockMe _mockMe;

        public InjectedWithMockMe(IMockMe mockMe)
        {
            _mockMe = mockMe;
        }

        public string GetFromMoqMe()
        {
            return _mockMe.GetSomeString();
        }
    }
}
