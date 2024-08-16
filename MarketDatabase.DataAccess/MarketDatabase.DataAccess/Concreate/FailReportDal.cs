using MarketDatabase.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDatabase.DataAccess.Concreate
{
    public class FailReportDal:IFailReport
    {
        public void UpdateSalesBetweenDates(DateTime startDate, DateTime endDate, decimal newPrice)
        {
            using (ContextMarketDatabase _context = new ContextMarketDatabase())
            {
                var salesToUpdate = _context.failReports
                                       .Where(s => s.SaleData >= startDate && s.SaleData <= endDate)
                                       .ToList();

                foreach (var sale in salesToUpdate)
                {
                    sale.SalePrice = newPrice;
                }

                _context.SaveChanges();
            }
        }
    }
}
