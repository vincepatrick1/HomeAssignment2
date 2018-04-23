using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HomeAssignment2.MyClasses;

namespace HomeAssignment2.AccountPages
{
    public partial class LoanApplicationPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Customer cust = (Customer)Session["custObj"];
            NameLabel.Text = cust.FullName;
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            double loanAmount = double.Parse(LoanTextBox.Text);
            int age = int.Parse(AgeTextBox.Text);
            double salary = double.Parse(SalaryTextBox.Text);


            List<Account> listObj = (List<Account>)Session["listObj"];
            int lbObj = (int)Session["lbObj"];


            Account acct = listObj[lbObj];
            if (loanAmount <= acct.Balance && age > 18 && loanAmount < (.5 * salary))
            {
                LoanApprovalLabel.Text = "Congratulations!! Your loan is approved";
            }
            else
            {
                LoanApprovalLabel.Text = "Your loan is not approved. Sorry!!";
            }
        }
    }
}