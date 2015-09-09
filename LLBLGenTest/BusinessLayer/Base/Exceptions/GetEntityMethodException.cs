using System;
using BusinessLayer;

namespace LLBLGenTest.Application.Base.Exceptions
{
    public class GetEntityMethodException : BusinessManagerException
    {
        public GetEntityMethodException(Type managerType)
            : base("'{0}' Manager'ının GetEntity(int id) methodu implement edilmemiş. Bu metod diğer metodlar gibi abstract değil, fakat kullanılması gerektiğinde, ilgili business managerda overload edilmelidir. Alternatif olarak, parametreli GetEntity metodunu kullanabilir veya Manager'da overloadını yazabilirsiniz.".FormatString(managerType.Name))
        {
        }
    }
}
