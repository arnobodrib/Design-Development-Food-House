using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProject.Model.Model;
using WebProject.DatabaseContext.DatabaseContext;


namespace WebProject.Repository.Repository
{
    public class AccountRepository
    {
        ProjectDbContext _dbContext = new ProjectDbContext();

        public string Login(Account account)
        {
           return _dbContext.Accountes.Where(x => x.UserName == account.UserName && x.Password == account.Password).Select(x=>x.UserType).FirstOrDefault();
        }



        //public bool Add(Account account)
        //{
        //    _dbContext.Accountes.Add(account);
        //    return _dbContext.SaveChanges() > 0;
        //}














        //public string UniqueTest(Account account)
        //{
        //    bool isNUnq, isCUnq;
        //    string errString = "";

        //    if ((_dbContext.Accountes.FirstOrDefault(a => a.UserName == a.UserName)) == null)
        //    {
        //        isNUnq = true;
        //        errString += "";
        //    }
        //    else
        //    {
        //        isNUnq = false;
        //        errString += "You have no Uniq Account";
        //    }


        //    if ((_dbContext.Accountes.FirstOrDefault(a => account.Password == account.Password)) == null)
        //    {
        //        isCUnq = true;
        //        errString += "";
        //    }
        //    else
        //    {
        //        isCUnq = false;
        //        errString += " Password is not Unique";
        //    }

        //    return errString;

        //}
    }
}
