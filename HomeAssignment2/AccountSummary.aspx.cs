using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HomeAssignment2.MyClasses;

namespace March22ClassExercise
{
    public partial class AccountSummary : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (PreviousPage == null)
            {
                GenerateSessionObjects sessionobj = new GenerateSessionObjects();
                Customer cust = (Customer)Session["custObj"];
                List<Account> listObj = (List<Account>)Session["listObj"];

                HttpContext.Current.Session["lbObj"] = AccountListBox.SelectedIndex;

                WelcomeLabel.Text = "Welcome " + cust.FullName;
                foreach (Account a in listObj)
                {
                    AccountListBox.Items.Add(a.Nickname + a.Balance.ToString());
                }
            }
            
            
                else
            {

                    Customer cust = (Customer)Session["custObj"];
                    List<Account> listObj = (List<Account>)Session["listObj"];
                //HttpContext.Current.Session["lbObj"] = AccountListBox.SelectedIndex;
                Session.Remove("lbObj");
                Session.Add("lbObj", listObj);
                WelcomeLabel.Text = "Welcome " + cust.FullName;
                    foreach (Account a in listObj)
                    {
                        AccountListBox.Items.Add(a.Nickname + a.Balance.ToString());
                    }

                }


                //  HttpContext.Current.Session["lbObj"] = AccountListBox.SelectedIndex;
                // HttpContext.Current.Session["list"] = listObj;

            }
        

        public int Getselectedindex()
        {
            return AccountListBox.SelectedIndex;
        }





        protected void DeatailButton_Click(object sender, EventArgs e)
        {
            Server.Transfer("AccountPages/AccountDetails.aspx");
        }
    }
}
