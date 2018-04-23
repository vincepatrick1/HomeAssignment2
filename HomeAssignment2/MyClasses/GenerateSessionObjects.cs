using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeAssignment2.MyClasses
{
    public class GenerateSessionObjects
    {
        List<Account> objectList = new List<Account>();
        public GenerateSessionObjects()
        {
            Account acct1 = new Account();
            Account acct2 = new Account();
            Account acct3 = new Account();
            acct1.Nickname = "MyChk1";
            acct2.Nickname = "MyChk2";
            acct3.Nickname = "MySav3";
            acct1.Type = "Checking";
            acct2.Type = "Checking";
            acct3.Type = "Saving";
            acct1.Balance = 50000;
            acct2.Balance = 55000;
            acct3.Balance = 60000;
            objectList.Add(acct1);
            objectList.Add(acct2);
            objectList.Add(acct3);

            Customer cust = new Customer("Daniel Bert", "1234 Lane, Louisville 40208");
            HttpContext.Current.Session["custObj"] = cust;
            HttpContext.Current.Session["listObj"] = objectList;
        }
    }
}