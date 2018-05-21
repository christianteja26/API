using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BSIS.BoarderLogNightMonitoring.Model
{
    [Table("MsLogNightMonitoringReason")]
    public class Reason
    {
        [Key]
        public int ReasonID { get; set; }
        public string ReasonName { get; set; }
    }
}