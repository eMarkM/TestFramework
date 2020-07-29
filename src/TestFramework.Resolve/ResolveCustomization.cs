using System.Reflection;
using AutoFixture;

namespace TestFramework.Resolve

{
    /// <summary>
    /// Resolve an object using <see cref="IDependencyResolver"/>.
    /// </summary>
    class ResolveCustomization : ICustomization
    {
        private readonly Assembly _assembly;

        public ResolveCustomization(Assembly assembly)
        {
            _assembly = assembly;
        }

        public void Customize(IFixture fixture)
        {
            fixture.Customizations.Add(new DependencyResolverSpecimenBuilder(_assembly));
        }
    }
}
