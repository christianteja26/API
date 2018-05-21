using BSIS.BoarderLogNightMonitoring.Data.Infrastructure;
using BSIS.BoarderLogNightMonitoring.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BSIS.BoarderLogNightMonitoring.Data.Repositories
{
    public class LogNightRepository : RepositoryBase<LogNight>, ILogNightRepository
    {
        public LogNightRepository(IDbFactory DbFactory) : base(DbFactory) { }
        public LogNightRepository() : base() { }
    }

    public interface ILogNightRepository : IRepository<LogNight>
    {

    }
}