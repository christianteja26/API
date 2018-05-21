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
    public class ActiveBoarder
    {
        [Key]
        public string RegistrationID { get; set; }
        public string BinusianID { get; set; }
        public string NIM { get; set; }
        public string BoarderName { get; set; }
        public string CardID { get; set; }
        public byte[] Photo { get; set; }
    }
}
