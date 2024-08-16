using MarketDatabase.DataAccess.Abstract;
using MarketDatabase.DataAccess.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDatabse.Business
{
    public class FailReportManager
    {
        private IFailReport _failreport;
        public FailReportManager(IFailReport failReport)
        {
            _failreport = failReport;
        }
        public void UpdateSalesBetweenDates(DateTime startDate, DateTime endDate, decimal newPrice)
        {
            _failreport.UpdateSalesBetweenDates(startDate, endDate, newPrice);
        }
    }
}
