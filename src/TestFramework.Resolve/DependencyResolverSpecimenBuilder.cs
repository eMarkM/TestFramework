using System;
using System.Linq;
using System.Reflection;

namespace TestFramework.Resolve
{
    /// <summary>
    /// Resolve an object using an implementation of IDependencyResolver.
    /// There should only be one implementation of this in your test framework project.
    /// </summary>
    class DependencyResolverSpecimenBuilder : AbstractSpecimenBuilder
    {
        private Type _typeToResolve;
        private readonly Assembly _assembly;

        public DependencyResolverSpecimenBuilder(Assembly assembly)
        {
            _assembly = assembly;
        }

        protected override object Create()
        {
            var types = ReflectionUtilities.FindAllImplementations<IDependencyResolver>(_assembly);
            var enumerable = types as Type[] ?? types.ToArray();

            if (enumerable.Count() != 1)
            {
                throw new InvalidOperationException($"Only expecting one implementation of IDependencyResolver, but found {enumerable.Count()}");
            }
            Type resolverType = enumerable.Single();

            IDependencyResolver resolver = (IDependencyResolver)Activator.CreateInstance(resolverType);

            return resolver.Resolve(_typeToResolve);
        }

        protected override bool MeetsCriteria(ParameterInfo parameterInfo)
        {
            _typeToResolve = parameterInfo.ParameterType;
            return true;
        }

        protected override bool MeetsCriteria(PropertyInfo propertyInfo)
        {
            _typeToResolve = propertyInfo.PropertyType;
            return true;
        }
    }
}
