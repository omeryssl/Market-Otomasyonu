using MarketDatabase.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MarketDatabase.DataAccess.Abstract
{
    public interface IFailReport
    {
        void UpdateSalesBetweenDates(DateTime startDate, DateTime endDate, decimal newPrice);
    }
}
