using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProject.Model.Model;
using WebProject.Repository.Repository;

namespace WebProject.BLL.BLL
{
    public class SalesManager
    {

        SalesRepository _salesRepository = new SalesRepository();

        public string GetSalesCode()
        {
            return _salesRepository.GetSalesCode();
        }

    }
}
