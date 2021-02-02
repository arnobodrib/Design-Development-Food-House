using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProject.Repository.Repository;
using WebProject.Model.Model;

namespace WebProject.BLL.BLL
{
    public class ProductManager
    {
        ProductRepository _productRepository = new ProductRepository();


        public bool Add(Product product)
        {
            return _productRepository.Add(product);
        }
        
        public bool Update(Product product)
        {
            return _productRepository.Update(product);
        }
        public bool Delete(Product product)
        {
            return _productRepository.Delete(product);
        }
        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }
        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }
        public bool IsCodeExist(string code)
        {
            return _productRepository.IsCodeExist(code);
        }

        public bool IsNameExist(string name)
        {
            return _productRepository.IsNameExist(name);
        }

      

    }
}
