using System;
using TestFramework.Resolve;

namespace TestFramework.Tests.Attributes
{
    public class TestResolver : IDependencyResolver
    {
        public object Resolve(Type type)
        {
            if (type == typeof(ObjectWithDependencies))
            {
                return new ObjectWithDependencies(new SomeDepImpl());
            }
            if (type == typeof(IFoo))
            {
                return new Foo();
            }
            return null;
        }
    }
}