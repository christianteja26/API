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
    [Table("TrBoarderLogNightMonitoring")]
    public class LogNight
    {
        [Key]
        public string BoarderLogNightMonitoringID { get; set; }
        public string RegistrationID { get; set; }
        public string CheckOutDate { get; set; }
        public string CheckInDate { get; set; }
        public string ReasonName { get; set; }
    }
}