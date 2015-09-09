using System;

namespace LLBLGenTest.Application.Base.Exceptions
{
    public class EntityNotFoundException : BusinessManagerException
    {
        public EntityNotFoundException(Type entityType, EntityDataSourceParameterBase parameter)
            : base(String.Format("'{0}' tipindeki entity'ler çekilirken hiçbir entity bulunamadı.  {1}", entityType.Name, parameter))
        {

        }
    }
}
