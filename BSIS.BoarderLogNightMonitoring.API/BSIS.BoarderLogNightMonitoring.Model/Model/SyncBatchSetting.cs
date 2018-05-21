﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BSIS.BoarderLogNightMonitoring.Model
{
    public class SyncBatchSetting
    {
        [Key]
        public int Batch { get; set; }
        public int RowPerBatch { get; set; }
    }
}