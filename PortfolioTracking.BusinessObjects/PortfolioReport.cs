using System;
using System.Collections.Generic;

namespace PortfolioTracking.BusinessObjects
{
    public class PortfolioReport
    {
        public long PortfolioID { get; set; }
        public string PortfolioName { get; set; }
        public DateTime WhenCreated { get; set; }
        public List<ProfitReport> ProfitReports { get; set; }
    }
}
