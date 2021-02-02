using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProject.Model.Model;
using WebProject.Repository.Repository;

namespace WebProject.BLL.BLL
{
    public class AccountManager
    {

        AccountRepository _accountRepository = new AccountRepository();



        //public string UniqueTest(Account account)
        //{
        //    return _accountRepository.UniqueTest(account);
        //}

        public string Login(Account account)
        {
            return _accountRepository.Login(account);
        }

        //public bool Add(Account account)
        //{
        //    return _accountRepository.Add(account);
        //}





    }
}
