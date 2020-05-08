using System.Reflection;
using AutoFixture.Kernel;

namespace TestFramework
{
    /// <summary>
    /// Base class for most <see cref="ISpecimenBuilder"/> creation needs.
    /// Will examine both ParameterInfo and PropertyInfo.  Subclasses
    /// override the MeetsCriteria methods and return true if the Info
    /// meets the criteria for building. Then calls the Create method
    /// to populate the property/param
    /// </summary>
    public abstract class AbstractSpecimenBuilder : ISpecimenBuilder
    {
        protected ISpecimenContext SpecimenContext;

        public object Create(object request, ISpecimenContext context)
        {
            SpecimenContext = context;

            switch (request)
            {
                case ParameterInfo parameterInfo when MeetsCriteria(parameterInfo):
                    return Create();
                case PropertyInfo propertyInfo when MeetsCriteria(propertyInfo):
                    return Create();
                default:
                    return new NoSpecimen();
            }
        }

        /// <summary>
        /// Does ParameterInfo meet criteria to be built
        /// </summary>
        /// <param name="parameterInfo">info to examine</param>
        /// <returns>true if ParameterInfo meets criteria</returns>
        protected abstract bool MeetsCriteria(ParameterInfo parameterInfo);

        /// <summary>
        /// Does PropertyInfo meet criteria to be built
        /// </summary>
        /// <param name="propertyInfo">info to examine</param>
        /// <returns>true if PropertyInfo meets criteria</returns>
        protected abstract bool MeetsCriteria(PropertyInfo propertyInfo);

        /// <summary>
        /// Create the object that met the criteria
        /// </summary>
        /// <returns>instantiated object</returns>
        protected abstract object Create();
    }
}