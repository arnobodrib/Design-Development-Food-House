using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProject.Model.Model;
using WebProject.DatabaseContext.DatabaseContext;

namespace WebProject.Repository.Repository
{
    public class CustomerRepository
    {
        ProjectDbContext _dbContext = new ProjectDbContext();

        public bool Add(Customer customer)
        {
            _dbContext.Customers.Add(customer);
            return _dbContext.SaveChanges() > 0;
        }
        public List<Customer> GetAll()
        {
            return _dbContext.Customers.ToList();
        }

        public Customer GetById(int id)
        {
            return _dbContext.Customers.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(Customer customer)
        {
            var acustomer = _dbContext.Customers.FirstOrDefault(c => c.Id == customer.Id);

            //acustomer.Code - customer.Code;
            acustomer.Name = customer.Name;
            acustomer.Email = customer.Email;
            acustomer.DateTime = customer.DateTime;
            acustomer.Message = customer.Message;

            return _dbContext.SaveChanges() > 0;
        }

        //public string UniqueTest(Customer customer)
        //{
        //    bool isContactUnq, isCodeUnq, isEmailUnq;
        //    string errString = "";

        //    if ((_dbContext.Customers.FirstOrDefault(c => c.Code == customer.Code)) == null)
        //    {
        //        isCodeUnq = true;
        //        errString += "";
        //    }
        //    else
        //    {
        //        isCodeUnq = false;
        //        errString += "Code is not Unique ";
        //    }


        //    if ((_dbContext.Customers.FirstOrDefault(c => c.Email == customer.Email)) == null)
        //    {
        //        isEmailUnq = true;
        //        errString += "";
        //    }
        //    else
        //    {
        //        isEmailUnq = false;
        //        errString += " Email is not Unique";
        //    }

        //    if ((_dbContext.Customers.FirstOrDefault(c => c.Contact == customer.Contact)) == null)
        //    {
        //        isContactUnq = true;
        //        errString += "";
        //    }

        //    else
        //    {
        //        isContactUnq = false;
        //        errString += " Contact is not Unique";
        //    }

        //    return errString;

        //}

        //public string UniqueTestUpdate(Customer customer)
        //{
        //    bool isContactUnq, isCodeUnq, isEmailUnq;
        //    string errString = "";
        //    var acustomer = _dbContext.Customers.FirstOrDefault(c => c.Code == customer.Code);
        //    if (acustomer==null)
        //    {
        //        isCodeUnq = true;
        //        errString += "";
        //    }
        //    else if(acustomer != null && acustomer.Id==customer.Id)
        //    {
        //        isCodeUnq = true;
        //        errString += "";
        //    }
        //    else
        //    {
        //        isCodeUnq = false;
        //        errString += "Code is not Unique ";
        //    }


        //    if ((_dbContext.Customers.FirstOrDefault(c => c.Email == customer.Email)) == null)
        //    {
        //        isEmailUnq = true;
        //        errString += "";
        //    }
        //    else
        //    {
        //        isEmailUnq = false;
        //        errString += " Email is not Unique";
        //    }

        //    if ((_dbContext.Customers.FirstOrDefault(c => c.Contact == customer.Contact)) == null)
        //    {
        //        isContactUnq = true;
        //        errString += "";
        //    }

        //    else
        //    {
        //        isContactUnq = false;
        //        errString += " Contact is not Unique";
        //    }

        //    return errString;

        //}


    }
}
