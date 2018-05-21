using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSIS.BoarderLogNightMonitoring.Model
{
    public class EnumerableResponse<T> : BaseResponse
    {
        public IEnumerable<T> reasons;
        public IEnumerable<T> configs;
        public IEnumerable<T> activeBoarders;
        public IEnumerable<T> logNights;
        public IEnumerable<T> activeBoarderCounts;
        public IEnumerable<T> checkOutBoarders;
    }
}
