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
    public class ConfigurationRepository : RepositoryBase<Configuration>, IConfigurationRepository
    {
        public ConfigurationRepository(IDbFactory DbFactory) : base(DbFactory) { }
        public ConfigurationRepository() : base() { }
    }

    public interface IConfigurationRepository : IRepository<Configuration>
    {

    }
}