using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using WebProject.Model.Model;
using WebProject.DatabaseContext.DatabaseContext;


namespace WebProject.Repository.Repository
{
    public class PurchaseRepository
    {
        ProjectDbContext _dbContext = new ProjectDbContext();

        public bool Add(Purchase purchase)
        {
            _dbContext.Purchases.Add(purchase);

            if (DecreaseReorderLevel(purchase.PurchaseDetails))
                return _dbContext.SaveChanges() > 0;
            else
                return false;

            
        }
        public bool DecreaseReorderLevel(List<PurchaseDetails> purchaseDetails)
        {
            Product product;
            for(int i=0; i<purchaseDetails.Count(); i++)
            {
                int id = purchaseDetails[i].ProductId;
                product = _dbContext.Products.Where(d => d.Id == id).First();
                product.Recorder_Level = product.Recorder_Level+ purchaseDetails[i].Quantity;
                _dbContext.SaveChanges();
            }
            return true;
        }
        public bool Delete(Purchase purchase)
        {
            Purchase aPurchase = _dbContext.Purchases.FirstOrDefault();
            _dbContext.Purchases.Remove(aPurchase);
            return _dbContext.SaveChanges() > 0;
        }

        public List<Purchase> GetAll()
        {
            return _dbContext.Purchases.ToList();
        }
        public Purchase GetById(int id)
        {
            return _dbContext.Purchases.FirstOrDefault(c => c.Id == id);
        }
        public Purchase GetByInvoiceNo(string invoiceNo)
        {
            return _dbContext.Purchases.FirstOrDefault(c => c.InvoiceNo == invoiceNo);
        }

        //var studentName = ctx.Students.SqlQuery("").FirstOrDefault<Student>();
        public PurchaseDetails GetPurchaseDetails(int productId,int categoryId)
        {
            //return _dbContext.PurchaseDetails.SqlQuery("SELECT TOP 1 * FROM PurchaseDetails where ProductId=" + productId+" ORDER BY Id DESC").FirstOrDefault();
            return _dbContext.PurchaseDetails.SqlQuery("SELECT TOP 1 * FROM PurchaseDetails where ProductId=" + productId + " and CategoryID = " + categoryId + " ORDER BY Id DESC").FirstOrDefault();
        }
        public List<PurchaseDetails> GetPurchaseQuantityDetails(int productId, int categoryId)
        {
            return _dbContext.PurchaseDetails.Where(d => d.ProductId == productId && d.CategoryId == categoryId).ToList(); ;
            //return _dbContext.PurchaseDetails.SqlQuery("SELECT * FROM PurchaseDetails where ProductId=" + productId + " and CategoryID = " + categoryId + "").FirstOrDefault());
        }
        public bool IsInvoiceNoExist(string invoiceNo)
        {
            var isExist = _dbContext.Purchases.FirstOrDefault(c => c.InvoiceNo == invoiceNo);
            return isExist != null;
        }
    }
}
