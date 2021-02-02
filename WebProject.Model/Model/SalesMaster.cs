using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProject.Model.Model
{
    public class SalesMaster
    {
        public SalesMaster()
        {
            SalesDetails = new List<SalesDetail>();
        }
        public int Id { get; set; }
        public string SalesCode { get; set; }
        public string Date { get; set; }
        public float GrandTotal { get; set; }
        public int Discount { get; set; }
        public float DiscountAmount { get; set; }
        public float PayableAmount { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public virtual List<SalesDetail> SalesDetails { get; set; }

    }
}
