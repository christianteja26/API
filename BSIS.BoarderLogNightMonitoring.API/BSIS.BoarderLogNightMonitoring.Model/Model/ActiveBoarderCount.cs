using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace BSIS.BoarderLogNightMonitoring.Model
{
    public class ActiveBoarderCount
    {
        [Key]
        public int TotalRec { get; set; }
    }
}
