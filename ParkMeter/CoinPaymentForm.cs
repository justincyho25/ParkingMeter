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
    public partial class CoinPaymentForm : Form
    {
        private double paid = 0;
        private double owed;

        public CoinPaymentForm()
        {
            InitializeComponent();
            owed = Payment.getAmountOwing();

            totalAmount.Text = "Total Amount: "+Payment.formatMoney(Payment.getAmountOwing());
            amountPaid.Text = "Paid: $0.00";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            base.Close();
            PaymentForm pf = new PaymentForm();
            pf.Show();
        }

        private void nickelButton_Click(object sender, EventArgs e)
        {
            if(owed > paid)
            {
                paid = paid + 0.05;
                amountPaid.Text = "Paid: " + Payment.formatMoney(paid);
            }
        }

        private void dimeButton_Click(object sender, EventArgs e)
        {
            if (owed > paid)
            {
                paid = paid + 0.10;
                amountPaid.Text = "Paid: " + Payment.formatMoney(paid);
            }
        }

        private void quarterButton_Click(object sender, EventArgs e)
        {
            if (owed > paid)
            {
                paid = paid + 0.25;
                amountPaid.Text = "Paid: " + Payment.formatMoney(paid);
            }
        }

        private void loonieButton_Click(object sender, EventArgs e)
        {
            if (owed > paid)
            {
                paid = paid + 1.00;
                amountPaid.Text = "Paid: " + Payment.formatMoney(paid);
            }
        }

        private void toonieButton_Click(object sender, EventArgs e)
        {
            if (owed > paid)
            {
                paid = paid + 2.00;
                amountPaid.Text = "Paid: " + Payment.formatMoney(paid);
            }
        }

        private void fiveDollarButton_Click(object sender, EventArgs e)
        {
            if (owed > paid)
            {
                paid = paid + 5.00;
                amountPaid.Text = "Paid: " + Payment.formatMoney(paid);
            }
        }

        private void tenDollarButton_Click(object sender, EventArgs e)
        {
            if (owed > paid)
            {
                paid = paid + 10.00;
                amountPaid.Text = "Paid: " + Payment.formatMoney(paid);
            }
        }

        private void twentyDollarButton_Click(object sender, EventArgs e)
        {
            if (owed > paid)
            {
                paid = paid + 20.00;
                amountPaid.Text = "Paid: " + Payment.formatMoney(paid);
            }
        }

        private void fiftyDollarButton_Click(object sender, EventArgs e)
        {
            if (owed > paid)
            {
                paid = paid + 50.00;
                amountPaid.Text = "Paid: " + Payment.formatMoney(paid);
            }
        }

        private void hundredDollarButton_Click(object sender, EventArgs e)
        {
            if (owed > paid)
            {
                paid = paid + 100.00;
                amountPaid.Text = "Paid: " + Payment.formatMoney(paid);
            }
        }

        private void amountPaid_TextChanged(object sender, EventArgs e)
        {
            if (paid > owed)
            {
                sufficientFunds.ForeColor = System.Drawing.Color.Green;
                sufficientFunds.Text = "SUFFICIENT FUNDS";
                nickelButton.Enabled = false;
                dimeButton.Enabled = false;
                quarterButton.Enabled = false;
                loonieButton.Enabled = false;
                toonieButton.Enabled = false;
                fiveDollarButton.Enabled = false;
                tenDollarButton.Enabled = false;
                twentyDollarButton.Enabled = false;
                fiftyDollarButton.Enabled = false;
                hundredDollarButton.Enabled = false;
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if(paid < owed)
            {
                sufficientFunds.ForeColor = System.Drawing.Color.Red;
                sufficientFunds.Text = "INSUFFICIENT FUNDS";
            }
            else
            {
                base.Close();
                CoinDispenseForm cdf = new CoinDispenseForm(paid);
                cdf.Show();
            }
        }
    }
}
