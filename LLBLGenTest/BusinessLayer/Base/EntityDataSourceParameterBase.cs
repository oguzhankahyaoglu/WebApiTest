using System;
using System.Linq;
using System.Reflection;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace LLBLGenTest.Application.Base
{
    public class EntityDataSourceParameterBase
    {
        /// <summary>
        /// Calculate total count of entities
        /// </summary>
        public bool CalculateAggregate { get; set; }
        public int Aggregate { get; set; }

        public int ItemsToReturn { get; set; }

        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public EntityDataSourceParameterBase()
        {
            //PageNumber = 1;
            //PageSize = 10;
        }

        /// <summary>
        /// Adds requeired subpaths
        /// </summary>
        public Action<PrefetchPath2> PathsFunc { get; set; }

        /// <summary>
        /// Adds filters to query.
        /// </summary>
        public Action<PredicateExpression> FiltersFunc { get; set; }

        #region ToString methods

        private const String NULL = "[NULL]";
        public override string ToString()
        {
            //Get only setted properties
            var notNullPropertyValues = GetPropertyValuesString(this, 1, false);
            var detailedPropertyValues = GetPropertyValuesString(this, 1, true);
            return "\n" + detailedPropertyValues;
        }

        private String GenerateTabs(int indentLevel)
        {
            return new string('x', indentLevel * 7).Replace("x", "-");
        }

        private String GetPropertyValuesString(object containerObject, int indentLevel, bool showNullValues)
        {
            var containerType = containerObject.GetType();
            var properties = containerType.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly);
            var propertyValuesStrArr = properties
                .Where(p => showNullValues || p.GetValue(containerObject, null) != null)
                .Select(p => GetPropertyValueString(containerObject, p, indentLevel, showNullValues))
                .ToArray();
            var propertiesStr = String.Join("", propertyValuesStrArr);
            return String.Format("{0}{1}: {{\n{2}{0}}},\n", GenerateTabs(indentLevel - 1), containerType.Name, propertiesStr);
        }

        private String GetPropertyValueString(object containerObject, PropertyInfo property, int indentLevel, bool showNullValues)
        {
            var propertyName = property.Name;
            var propertyValue = property.GetValue(containerObject, null);
            if (propertyValue is EntityDataSourceParameterBase)
            {
                var extendedParameter = propertyValue as EntityDataSourceParameterBase;
                return GetPropertyValuesString(extendedParameter, indentLevel + 1, showNullValues);
            }
            return String.Format("{0}{1}: {2},\n", GenerateTabs(indentLevel), propertyName, propertyValue ?? NULL);
        }

        #endregion
    }
}
