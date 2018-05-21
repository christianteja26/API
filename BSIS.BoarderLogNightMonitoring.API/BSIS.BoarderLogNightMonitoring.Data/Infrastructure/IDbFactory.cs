using BSIS.BoarderLogNightMonitoring.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSIS.BoarderLogNightMonitoring.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        BoarderContext Init();
    }
}
