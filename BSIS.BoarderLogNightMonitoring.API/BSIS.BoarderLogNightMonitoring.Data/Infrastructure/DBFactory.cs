﻿using BSIS.BoarderLogNightMonitoring.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSIS.BoarderLogNightMonitoring.Data.Infrastructure
{
    public class DBFactory : Disposable, IDbFactory
    {
        BoarderContext dbContext;

        public BoarderContext Init()
        {
            return dbContext ?? (dbContext = new BoarderContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
