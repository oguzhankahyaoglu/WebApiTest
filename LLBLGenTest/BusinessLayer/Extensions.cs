using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace BusinessLayer
{
    public static class Extensions
    {
        public static String FormatString(this string format, params object[] parameters)
        {
            return String.Format(format, parameters);
        }

        public static IPrefetchPathElement2 WithMaxNumberOfItems(this IPrefetchPathElement2 path, int maxNumber)
        {
            path.MaxAmountOfItemsToReturn = maxNumber;
            return path;
        }
    }
}
