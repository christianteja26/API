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
    public class ReasonRepository : RepositoryBase<Reason>, IReasonRepository
    {
        public ReasonRepository(IDbFactory DbFactory) : base(DbFactory) { }
        public ReasonRepository():base() { }
    }

    public interface IReasonRepository : IRepository<Reason>
    {

    }
}