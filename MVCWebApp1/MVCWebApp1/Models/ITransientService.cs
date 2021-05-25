using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApp1.Models
{
    public interface ITransientService
    {
        Guid GetOperationID();
    }

    public interface IScopedService
    {
        Guid GetOperationID();
    }

    public interface ISingletonService
    {
        Guid GetOperationID();
    }
}
