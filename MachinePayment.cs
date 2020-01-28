using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkMeter
{
    public partial class MachinePayment : Form
    {
        public MachinePayment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(machineDisplay.SelectionLength > 0)
            {
                if ((this.machineDisplay.Text.Length < 4) && (this.machineDisplay.Text.Length > 0))
                {
                    this.errorLabel.Text = "";
                    this.machineDisplay.Text = this.machineDisplay.Text + "1";
                    machineDisplay.Select(0, machineDisplay.Text.Length);
                }
                else
                {
                    if (this.machineDisplay.Text == "ENTER PIN")
                    {
                        this.machineDisplay.Text = "1";
                        this.errorLabel.Text = "";
                        machineDisplay.Select(0, machineDisplay.Text.Length);
                    }
                }
            }
            if(accountNumber.SelectionLength > 0)
            {
                if ((this.accountNumber.Text.Length < 16) && (this.accountNumber.Text.Length > 0))
                {
                    this.errorLabel.Text = "";
                    this.accountNumber.Text = this.accountNumber.Text + "1";
                    accountNumber.Select(0, accountNumber.Text.Length);
                }
                else
                {
                    if (this.accountNumber.Text == "ENTER ACCOUNT NUMBER")
                    {
                        this.accountNumber.Text = "1";
                        this.errorLabel.Text = "";
                        accountNumber.Select(0, accountNumber.Text.Length);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (machineDisplay.SelectionLength > 0)
            {
                if ((this.machineDisplay.Text.Length < 4) && (this.machineDisplay.Text.Length > 0))
                {
                    this.errorLabel.Text = "";
                    this.machineDisplay.Text = this.machineDisplay.Text + "2";
                    machineDisplay.Select(0, machineDisplay.Text.Length);
                }
                else
                {
                    if (this.machineDisplay.Text == "ENTER PIN")
                    {
                        this.machineDisplay.Text = "2";
                        this.errorLabel.Text = "";
                        machineDisplay.Select(0, machineDisplay.Text.Length);
                    }
                }
            }
            if (accountNumber.SelectionLength > 0)
            {
                if ((this.accountNumber.Text.Length < 16) && (this.accountNumber.Text.Length > 0))
                {
                    this.errorLabel.Text = "";
                    this.accountNumber.Text = this.accountNumber.Text + "2";
                    accountNumber.Select(0, accountNumber.Text.Length);
                }
                else
                {
                    if (this.accountNumber.Text == "ENTER ACCOUNT NUMBER")
                    {
                        this.accountNumber.Text = "2";
                        this.errorLabel.Text = "";
                        accountNumber.Select(0, accountNumber.Text.Length);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (machineDisplay.SelectionLength > 0)
            {
                if ((this.machineDisplay.Text.Length < 4) && (this.machineDisplay.Text.Length > 0))
                {
                    this.errorLabel.Text = "";
                    this.machineDisplay.Text = this.machineDisplay.Text + "3";
                    machineDisplay.Select(0, machineDisplay.Text.Length);
                }
                else
                {
                    if (this.machineDisplay.Text == "ENTER PIN")
                    {
                        this.machineDisplay.Text = "3";
                        this.errorLabel.Text = "";
                        machineDisplay.Select(0, machineDisplay.Text.Length);
                    }
                }
            }
            if (accountNumber.SelectionLength > 0)
            {
                if ((this.accountNumber.Text.Length < 16) && (this.accountNumber.Text.Length > 0))
                {
                    this.errorLabel.Text = "";
                    this.accountNumber.Text = this.accountNumber.Text + "3";
                    accountNumber.Select(0, accountNumber.Text.Length);
                }
                else
                {
                    if (this.accountNumber.Text == "ENTER ACCOUNT NUMBER")
                    {
                        this.accountNumber.Text = "3";
                        this.errorLabel.Text = "";
                        accountNumber.Select(0, accountNumber.Text.Length);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (machineDisplay.SelectionLength > 0)
            {
                if ((this.machineDisplay.Text.Length < 4) && (this.machineDisplay.Text.Length > 0))
                {
                    this.errorLabel.Text = "";
                    this.machineDisplay.Text = this.machineDisplay.Text + "4";
                    machineDisplay.Select(0, machineDisplay.Text.Length);
                }
                else
                {
                    if (this.machineDisplay.Text == "ENTER PIN")
                    {
                        this.machineDisplay.Text = "4";
                        this.errorLabel.Text = "";
                        machineDisplay.Select(0, machineDisplay.Text.Length);
                    }
                }
            }
            if (accountNumber.SelectionLength > 0)
            {
                if ((this.accountNumber.Text.Length < 16) && (this.accountNumber.Text.Length > 0))
                {
                    this.errorLabel.Text = "";
                    this.accountNumber.Text = this.accountNumber.Text + "4";
                    accountNumber.Select(0, accountNumber.Text.Length);
                }
                else
                {
                    if (this.accountNumber.Text == "ENTER ACCOUNT NUMBER")
                    {
                        this.accountNumber.Text = "4";
                        this.errorLabel.Text = "";
                        accountNumber.Select(0, accountNumber.Text.Length);
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (machineDisplay.SelectionLength > 0)
            {
                if ((this.machineDisplay.Text.Length < 4) && (this.machineDisplay.Text.Length > 0))
                {
                    this.errorLabel.Text = "";
                    this.machineDisplay.Text = this.machineDisplay.Text + "5";
                    machineDisplay.Select(0, machineDisplay.Text.Length);
                }
                else
                {
                    if (this.machineDisplay.Text == "ENTER PIN")
                    {
                        this.machineDisplay.Text = "5";
                        this.errorLabel.Text = "";
                        machineDisplay.Select(0, machineDisplay.Text.Length);
                    }
                }
            }
            if (accountNumber.SelectionLength > 0)
            {
                if ((this.accountNumber.Text.Length < 16) && (this.accountNumber.Text.Length > 0))
                {
                    this.errorLabel.Text = "";
                    this.accountNumber.Text = this.accountNumber.Text + "5";
                    accountNumber.Select(0, accountNumber.Text.Length);
                }
                else
                {
                    if (this.accountNumber.Text == "ENTER ACCOUNT NUMBER")
                    {
                        this.accountNumber.Text = "5";
                        this.errorLabel.Text = "";
                        accountNumber.Select(0, accountNumber.Text.Length);
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (machineDisplay.SelectionLength > 0)
            {
                if ((this.machineDisplay.Text.Length < 4) && (this.machineDisplay.Text.Length > 0))
                {
                    this.errorLabel.Text = "";
                    this.machineDisplay.Text = this.machineDisplay.Text + "6";
                    machineDisplay.Select(0, machineDisplay.Text.Length);
                }
                else
                {
                    if (this.machineDisplay.Text == "ENTER PIN")
                    {
                        this.machineDisplay.Text = "6";
                        this.errorLabel.Text = "";
                        machineDisplay.Select(0, machineDisplay.Text.Length);
                    }
                }
            }
            if (accountNumber.SelectionLength > 0)
            {
                if ((this.accountNumber.Text.Length < 16) && (this.accountNumber.Text.Length > 0))
                {
                    this.errorLabel.Text = "";
                    this.accountNumber.Text = this.accountNumber.Text + "6";
                    accountNumber.Select(0, accountNumber.Text.Length);
                }
                else
                {
                    if (this.accountNumber.Text == "ENTER ACCOUNT NUMBER")
                    {
                        this.accountNumber.Text = "6";
                        this.errorLabel.Text = "";
                        accountNumber.Select(0, accountNumber.Text.Length);
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (machineDisplay.SelectionLength > 0)
            {
                if ((this.machineDisplay.Text.Length < 4) && (this.machineDisplay.Text.Length > 0))
                {
                    this.errorLabel.Text = "";
                    this.machineDisplay.Text = this.machineDisplay.Text + "7";
                    machineDisplay.Select(0, machineDisplay.Text.Length);
                }
                else
                {
                    if (this.machineDisplay.Text == "ENTER PIN")
                    {
                        this.machineDisplay.Text = "7";
                        this.errorLabel.Text = "";
                        machineDisplay.Select(0, machineDisplay.Text.Length);
                    }
                }
            }
            if (accountNumber.SelectionLength > 0)
            {
                if ((this.accountNumber.Text.Length < 16) && (this.accountNumber.Text.Length > 0))
                {
                    this.errorLabel.Text = "";
                    this.accountNumber.Text = this.accountNumber.Text + "7";
                    accountNumber.Select(0, accountNumber.Text.Length);
                }
                else
                {
                    if (this.accountNumber.Text == "ENTER ACCOUNT NUMBER")
                    {
                        this.accountNumber.Text = "7";
                        this.errorLabel.Text = "";
                        accountNumber.Select(0, accountNumber.Text.Length);
                    }
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (machineDisplay.SelectionLength > 0)
            {
                if ((this.machineDisplay.Text.Length < 4) && (this.machineDisplay.Text.Length > 0))
                {
                    this.errorLabel.Text = "";
                    this.machineDisplay.Text = this.machineDisplay.Text + "8";
                    machineDisplay.Select(0, machineDisplay.Text.Length);
                }
                else
                {
                    if (this.machineDisplay.Text == "ENTER PIN")
                    {
                        this.machineDisplay.Text = "8";
                        this.errorLabel.Text = "";
                        machineDisplay.Select(0, machineDisplay.Text.Length);
                    }
                }
            }
            if (accountNumber.SelectionLength > 0)
            {
                if ((this.accountNumber.Text.Length < 16) && (this.accountNumber.Text.Length > 0))
                {
                    this.errorLabel.Text = "";
                    this.accountNumber.Text = this.accountNumber.Text + "8";
                    accountNumber.Select(0, accountNumber.Text.Length);
                }
                else
                {
                    if (this.accountNumber.Text == "ENTER ACCOUNT NUMBER")
                    {
                        this.accountNumber.Text = "8";
                        this.errorLabel.Text = "";
                        accountNumber.Select(0, accountNumber.Text.Length);
                    }
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (machineDisplay.SelectionLength > 0)
            {
                if ((this.machineDisplay.Text.Length < 4) && (this.machineDisplay.Text.Length > 0))
                {
                    this.errorLabel.Text = "";
                    this.machineDisplay.Text = this.machineDisplay.Text + "9";
                    machineDisplay.Select(0, machineDisplay.Text.Length);
                }
                else
                {
                    if (this.machineDisplay.Text == "ENTER PIN")
                    {
                        this.machineDisplay.Text = "9";
                        this.errorLabel.Text = "";
                        machineDisplay.Select(0, machineDisplay.Text.Length);
                    }
                }
            }
            if (accountNumber.SelectionLength > 0)
            {
                if ((this.accountNumber.Text.Length < 16) && (this.accountNumber.Text.Length > 0))
                {
                    this.errorLabel.Text = "";
                    this.accountNumber.Text = this.accountNumber.Text + "9";
                    accountNumber.Select(0, accountNumber.Text.Length);
                }
                else
                {
                    if (this.accountNumber.Text == "ENTER ACCOUNT NUMBER")
                    {
                        this.accountNumber.Text = "9";
                        this.errorLabel.Text = "";
                        accountNumber.Select(0, accountNumber.Text.Length);
                    }
                }
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (machineDisplay.SelectionLength > 0)
            {
                if ((this.machineDisplay.Text.Length < 4) && (this.machineDisplay.Text.Length > 0))
                {
                    this.errorLabel.Text = "";
                    this.machineDisplay.Text = this.machineDisplay.Text + "0";
                    machineDisplay.Select(0, machineDisplay.Text.Length);
                }
                else
                {
                    if (this.machineDisplay.Text == "ENTER PIN")
                    {
                        this.machineDisplay.Text = "0";
                        this.errorLabel.Text = "";
                        machineDisplay.Select(0, machineDisplay.Text.Length);
                    }
                }
            }
            if (accountNumber.SelectionLength > 0)
            {
                if ((this.accountNumber.Text.Length < 16) && (this.accountNumber.Text.Length > 0))
                {
                    this.errorLabel.Text = "";
                    this.accountNumber.Text = this.accountNumber.Text + "0";
                    accountNumber.Select(0, accountNumber.Text.Length);
                }
                else
                {
                    if (this.accountNumber.Text == "ENTER ACCOUNT NUMBER")
                    {
                        this.accountNumber.Text = "0";
                        this.errorLabel.Text = "";
                        accountNumber.Select(0, accountNumber.Text.Length);
                    }
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            base.Close();
            PaymentForm pf = new PaymentForm();
            pf.Show();
        }

        private void correctionButton_Click(object sender, EventArgs e)
        {
            if (machineDisplay.SelectionLength > 0)
            {
                if (this.machineDisplay.Text.Length <= 4 && this.machineDisplay.Text.Length > 1)
                {
                    this.machineDisplay.Text = this.machineDisplay.Text.Remove(this.machineDisplay.Text.Length - 1);
                    this.errorLabel.Text = "";
                    machineDisplay.Select(0, machineDisplay.Text.Length);
                }
                else
                {
                    this.machineDisplay.Text = "ENTER PIN";
                    this.errorLabel.Text = "";
                    machineDisplay.Select(0, machineDisplay.Text.Length);
                }
            }

            else if (accountNumber.SelectionLength > 0)
            {
                if (this.accountNumber.Text.Length <= 16 && this.accountNumber.Text.Length > 1)
                {
                    this.accountNumber.Text = this.accountNumber.Text.Remove(this.accountNumber.Text.Length - 1);
                    this.errorLabel.Text = "";
                    accountNumber.Select(0, accountNumber.Text.Length);
                }
                else
                {
                    this.accountNumber.Text = "ENTER ACCOUNT NUMBER";
                    this.errorLabel.Text = "";
                    accountNumber.Select(0, accountNumber.Text.Length);
                }
            }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if(this.machineDisplay.Text.Length == 4 && this.accountNumber.Text.Length == 16)
            {
                base.Close();
                PrintTicketForm ptf = new PrintTicketForm();
                ptf.Show();
            }

            else if(this.machineDisplay.Text == "ENTER PIN" && this.accountNumber.Text == "ENTER ACCOUNT NUMBER")
            {
                this.errorLabel.Location = new Point(169, 129);
                this.errorLabel.Text = "INVALID PIN OR ACCOUNT NUMBER";
            }

            else if (this.accountNumber.Text.Length < 16 && this.machineDisplay.Text.Length < 4)
            {
                this.errorLabel.Location = new Point(169, 129);
                this.errorLabel.Text = "INVALID PIN OR ACCOUNT NUMBER";
            }

            else if (this.accountNumber.Text.Length < 16 && this.machineDisplay.Text == "ENTER PIN")
            {
                this.errorLabel.Location = new Point(169, 129);
                this.errorLabel.Text = "INVALID PIN OR ACCOUNT NUMBER";
            }

            else if (this.accountNumber.Text == "ENTER ACCOUNT NUMBER" && this.machineDisplay.Text.Length < 4)
            {
                this.errorLabel.Location = new Point(169, 129);
                this.errorLabel.Text = "INVALID PIN OR ACCOUNT NUMBER";
            }

            else if(this.machineDisplay.Text.Length < 4 || this.machineDisplay.Text == "ENTER PIN")
            {
                this.errorLabel.Location = new Point(268, 135);
                this.errorLabel.Text = "INVALID PIN";
            }

            else if(this.accountNumber.Text.Length < 16 || this.machineDisplay.Text == "ENTER ACCOUNT NUMBER")
            {
                this.errorLabel.Location = new Point(203, 124);  
                this.errorLabel.Text = "INVALID ACCOUNT NUMBER";
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            base.Close();
            PaymentForm pf = new PaymentForm();
            pf.Show();

        }

        private void accountNumber_Click(object sender, EventArgs e)
        {
            accountNumber.SelectAll();
            machineDisplay.Select(0, 0);
        }

        private void machineDisplay_Click(object sender, EventArgs e)
        {
            machineDisplay.SelectAll();
            accountNumber.Select(0, 0);
        }

        private void accountNumber_TextChanged(object sender, EventArgs e)
        {
            //if (accountNumber.Text.Length == 16)
            //{
            //    long hello = Int64.Parse(accountNumber.Text);
            //    this.accountNumber.Text = String.Format("{0:0000 0000 0000 0000}", hello);
            //}
        }
    }
}
