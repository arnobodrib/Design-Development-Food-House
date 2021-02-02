using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProject.Model.Model;
using WebProject.DatabaseContext.DatabaseContext;

namespace WebProject.Repository.Repository
{
    public class SalesRepository
    {
        ProjectDbContext _dbContext = new ProjectDbContext();

        public string GetSalesCode()
        {
            var MaxSalesId = _dbContext.SalesMasters.Max(c=>c.Id) + 1;
            string SalesId = MaxSalesId.ToString().PadLeft(4,'0');

            DateTime dt = new DateTime();
            string Year = dt.Year.ToString();

            string SalesCode = Year + "-" + SalesId;

            return SalesCode;
        }

    }
}
