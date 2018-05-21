using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BSIS.BoarderLogNightMonitoring.Model;

namespace BSIS.BoarderLogNightMonitoring.Data.Context
{
    public class BoarderContext : DbContext
    {
        public BoarderContext() : base("BSISDBConnectionString") { }
        public DbSet<Reason> Reasons { get; set; }
        public DbSet<Configuration> Configurations { get; set; }
        public DbSet<LogNight> LogNights { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}