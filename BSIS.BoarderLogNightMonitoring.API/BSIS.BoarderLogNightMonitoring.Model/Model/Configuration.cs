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
    [Table("MsConfig")]
    public class Configuration
    {
        [Key]
        public Int16 ConfigID { get; set; }
        public string ConfigName { get; set; }
        public string Value { get; set; }
    }
}