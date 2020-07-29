using System;
using System.Reflection;
using AutoFixture.Xunit2;
using TestFramework.Resolve;
using Xunit;

namespace Hps.Common.TestFramework.Tests.Attributes
{
    public class ResolveAttributeTests
    {
        [Theory, AutoData]
        public void ResolveAttribute_Resolves_Object_Graph(
            [TestResolve]ObjectWithDependencies myObject)
        {
            Assert.Equal(SomeDepImpl.Data, myObject.SomeData);
        }

        [Theory, AutoData]
        public void ResolveAttribute_Resolves_Interface_Using_Resolver(
            [TestResolve] IFoo sut)
        {
            Assert.IsType<Foo>(sut);
        }
    }

    public class ObjectWithDependencies
    {
        private readonly ISomeDependency _someDep;

        public ObjectWithDependencies(ISomeDependency someDep)
        {
            _someDep = someDep;
        }

        public string SomeData => _someDep.SomeStuff;
    }

    public interface ISomeDependency
    {
        string SomeStuff { get; }
    }

    public class SomeDepImpl : ISomeDependency
    {
        public const string Data = "some stuff";

        public string SomeStuff => Data;
    }

    public class TestResolveAttribute : ResolveAttribute
    {
        public TestResolveAttribute()
        {
        }

        public override Assembly GetExecutingAssembly()
        {
            return Assembly.GetExecutingAssembly();
        }
    }

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

    public interface IFoo
    {
    }

    public class Foo : IFoo
    {

    }
}