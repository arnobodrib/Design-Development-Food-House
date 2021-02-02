using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProject.Model.Model;
using WebProject.Repository.Repository;


namespace WebProject.BLL.BLL
{
    public class SupplierManager
    {
        SupplierRepository _supplierRepository = new SupplierRepository();
        public bool Add(Supplier supplier)
        {
            return _supplierRepository.Add(supplier);
        }
        public List<Supplier> GetAll()
        {
            return _supplierRepository.GetAll();
        }
        public Supplier GetById(int id)
        {
            return _supplierRepository.GetById(id);
        }
        public bool Update(Supplier supplier)
        {
            return _supplierRepository.Update(supplier);
        }

        public string UniqueTest(Supplier supplier)
        {
            return _supplierRepository.UniqueTest(supplier);
        }
    }
}
