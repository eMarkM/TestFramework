using AutoFixture;
using AutoFixture.Xunit2;
using System.Reflection;

namespace TestFramework.Resolve
{
    /// <summary>
    /// Resolve an object.  This will look for an implementation of <see cref="IDependencyResolver"/> in the
    /// executing assembly.
    /// </summary>
    public abstract class ResolveAttribute : CustomizeAttribute
    {   
        public override ICustomization GetCustomization(ParameterInfo parameter)
        {
            return new ResolveCustomization(GetExecutingAssembly());
        }

        /// <summary>
        /// Implement this and simply return Assembly.GetExecutingAssembly()
        /// </summary>
        /// <returns></returns>
        public abstract Assembly GetExecutingAssembly();        
    }
}
