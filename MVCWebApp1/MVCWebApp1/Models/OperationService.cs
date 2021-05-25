using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApp1.Models
{
    public class OperationService : ITransientService, ISingletonService, IScopedService
    {
        Guid id;

        public OperationService()
        {
            id = Guid.NewGuid();
        }

        public Guid GetOperationID()
        {
            return id;
        }
    }
}
