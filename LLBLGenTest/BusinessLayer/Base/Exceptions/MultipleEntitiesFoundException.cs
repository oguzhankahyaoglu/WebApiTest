using System;

namespace LLBLGenTest.Application.Base.Exceptions
{
    public class MultipleEntitiesFoundException : BusinessManagerException
    {
        public MultipleEntitiesFoundException(Type entityType, EntityDataSourceParameterBase parameter)
            : base(String.Format("'{0}' tipindeki entity'ler çekilirken birden fazle entity bulundu. {1}", entityType.Name, parameter))
        {

        }
    }
}
