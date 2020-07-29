using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace TestFramework.Resolve
{
    /// <summary>
    /// Utilities for Assemblies
    /// </summary>
    public static class ReflectionUtilities
    {
        public static IEnumerable<Type> FindAllImplementations<T>(Assembly assembly)
        {            
            var types = assembly.GetTypes().
                Where(p => typeof(T).IsAssignableFrom(p));

            return types;
        }
    }
}