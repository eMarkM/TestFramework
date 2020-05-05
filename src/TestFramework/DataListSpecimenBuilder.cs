using System;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace TestFramework
{
    /// <summary>
    /// Match <see cref="TType"/> type and a field name in <see cref="IFieldList"/>.  On match,
    /// pull a random element from <see cref="IDataList{TType}"/>.
    /// </summary>
    /// <typeparam name="TType">type to match</typeparam>
    public abstract class DataListSpecimenBuilder<TType> : AbstractSpecimenBuilder
    {
        private static Random _rnd = new Random();

        protected override bool MeetsCriteria(ParameterInfo parameterInfo)
        {
            return parameterInfo.ParameterType == typeof(TType) && 
                   (Fields.Names.Contains(parameterInfo.Name, StringComparer.InvariantCultureIgnoreCase) ||
                    Fields.PartialNames.Any(name => CultureInfo.CurrentCulture.CompareInfo.IndexOf(parameterInfo.Name, name, CompareOptions.IgnoreCase) >= 0));
        }

        protected override bool MeetsCriteria(PropertyInfo propertyInfo)
        {
            return propertyInfo.PropertyType == typeof(TType) && 
                   (Fields.Names.Contains(propertyInfo.Name, StringComparer.InvariantCultureIgnoreCase) ||
                    Fields.PartialNames.Any(name => CultureInfo.CurrentCulture.CompareInfo.IndexOf(propertyInfo.Name, name, CompareOptions.IgnoreCase) >= 0));
        }

        protected override object Create()
        {
            return _rnd.Next(Data.List.Count);
        }

        protected abstract IFieldList Fields { get; }

        protected abstract IDataList<TType> Data { get; }
    }
}
