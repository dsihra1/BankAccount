using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BankAccount
{
    public partial class FrmTestAccounts : Form
    {
        public FrmTestAccounts()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {

            // create a display string variable and initialize to an empty string
            string display = "";

            // create two bank account objects using both constructors - with valid data
            BankAccount acc1 = new BankAccount(1, 43);
            BankAccount acc2 = new BankAccount(23, 24, "Mark Johns");

            // test one of the objects - get accessors --> add output to display string
            display += "Name: " + acc1.ClientName +
                        "\nAccount Number: " + acc1.AccNumber +
                        "\nDate Opened: " + acc1.OpenTime +
                        "\nBalance: " + acc1.Balance;

            // test one of the objects - set accessors  --> add output to display string
            acc1.ClientName = "Jones Jr";
            display += "\n\nName Change: " + acc1.ClientName;

            // test one of the objects - methods  --> add output to display string
            acc1.Deposit(1000);
            display += "\n\nDesposit $1000 - New Balance: " + acc1.Balance;
            acc1.Withdraw(23);
            display += "\nWithdraw $23 - New Balance: " + acc1.Balance;

            // show display string to user - use bank name in caption of message box
            MessageBox.Show(display, BankAccount.BankName);

            /*****************************Next Test*********************************/
            // reset display string to empty string
            display = "";
            // create one account using the 3 parameter constructor - invalid name
            BankAccount acc3 = new BankAccount(123445, 234, "");
            // use get accessor to check name  --> add output to display string
            display += "";
            // use set accessor to set invalid name  --> add output to display string
            acc3.ClientName = "";
            display += "\nName: " + acc3.ClientName;
            // use set accessor to set valid name  --> add output to display string
            acc3.ClientName = "";
            display += "\nName: " + acc3.ClientName;
            // show display sgtring to user - use bank name in caption of message box
            MessageBox.Show(display, BankAccount.BankName);
        }
    }
}
