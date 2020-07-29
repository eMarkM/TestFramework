using System;

namespace TestFramework.Resolve
{
    /// <summary>
    /// Implement one and only one version of this in your test framework using 
    /// your version of IOC container.  Used with ResolveAttribute which will
    /// find the version 
    /// </summary>
    public interface IDependencyResolver 
    {
        object Resolve(Type type);
    }
}
