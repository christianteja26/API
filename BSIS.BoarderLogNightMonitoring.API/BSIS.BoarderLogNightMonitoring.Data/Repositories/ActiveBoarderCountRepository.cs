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
    public class ActiveBoarderCountRepository : RepositoryBase<ActiveBoarderCount>, IActiveBoarderCountRepository
    {
        public ActiveBoarderCountRepository(IDbFactory DbFactory) : base(DbFactory) { }
        public ActiveBoarderCountRepository() : base() { }
    }

    public interface IActiveBoarderCountRepository : IRepository<ActiveBoarderCount>
    {

    }
}
