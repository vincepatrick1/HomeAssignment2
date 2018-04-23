using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HomeAssignment2.MyClasses;

namespace March22ClassExercise.AccountPages
{
    public partial class AccountDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Account> list = (List<Account>)Session["list"];
            Customer cust = (Customer)Session["custObj"];
            List<Account> listObj = (List<Account>)Session["listObj"];
            if (list == null)
            {
                
                int lbObj = (int)Session["lbObj"];
                Account acct = listObj[lbObj];
                NameLabel.Text = acct.Nickname;
                TypeLabel.Text = acct.Type;
                BalanceLabel.Text = acct.Balance.ToString("c");
                LoanLabel.Text = acct.hasLoanOffer().ToString();
                AddressLabel.Text = cust.FullAddress;
            }
            else
            {
                
                int lbObj = (int)Session["lbObj"];
                //Account acct = listObj[lbObj];
               Account acct = list[lbObj];

                NameLabel.Text = acct.Nickname;
                TypeLabel.Text = acct.Type;
                BalanceLabel.Text = acct.Balance.ToString("c");
                LoanLabel.Text = acct.hasLoanOffer().ToString();
                AddressLabel.Text = cust.FullAddress;

            }
        }

        //ListBox prevpageListBox = (ListBox)PreviousPage.FindControl("AccountListBox");
        //HttpContext.Current.Session["selectedObj"] = prevpageListBox;

        protected void WithdrawButton_Click(object sender, EventArgs e)
        {
            double withdrawlAmount = double.Parse(WithDrawTextBox.Text);
            
            List<Account> listObj = (List<Account>)Session["listObj"];
            int lbObj = (int)Session["lbObj"];
            Account acct = listObj[lbObj];
            listObj.Remove(acct);

            if (withdrawlAmount <= acct.Balance)
            {
                acct.Balance = acct.Balance - withdrawlAmount;
                acct.Nickname = "Test";
                BalanceLabel.Text = acct.Balance.ToString("c");
                //HttpContext.Current.Session["acct"] = acct;
                
                listObj.Add(acct);
                //Session.Remove("listObj");
                //Session.Add("listObj", listObj);
                HttpContext.Current.Session["list"] = listObj;
                
            }

            else
            {
                WithdrawlErrorLabel.Text = "Withdrawl Amount is greater than Balance";
            }
            }
        }
    }

    
    //int selectedIndex = ((ListBox)PreviousPage.FindControl("AccountListBox")).SelectedIndex;
    //Account acct = listobj[selectedIndex];
