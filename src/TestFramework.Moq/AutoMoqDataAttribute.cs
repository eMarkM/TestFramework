using AutoFixture;
using AutoFixture.AutoMoq;
using AutoFixture.Xunit2;

namespace TestFramework.Moq
{
    /// <summary>
    /// Automatically mock data using Moq when attribute is applied to XUnit Theory.
    /// This should be combined with use of the <see cref="FrozenAttribute"/> in AutoFixture.Xunit2 
    /// when creating Mocks that will be used by a SUT.
    /// </summary>
    public class AutoMoqDataAttribute : AutoDataAttribute
    {
        public AutoMoqDataAttribute()
            : base(() => new Fixture().Customize(new AutoMoqCustomization()))
        {
        }
    }
}
