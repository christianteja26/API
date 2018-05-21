using BSIS.BoarderLogNightMonitoring.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSIS.BoarderLogNightMonitoring.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory DBFactory;
        private BoarderContext DBContext;

        public UnitOfWork(IDbFactory DbFactory)
        {
            this.DBFactory = DbFactory;
        }

        public BoarderContext DbContext
        {
            get { return DBContext ?? (DBContext = DBFactory.Init()); }
        }

        public void Commit()
        {
            DBContext.Commit();
        }
    }
}
