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
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
            this.amountOwing.Text = "Total: "+Payment.formatMoney(Payment.getAmountOwing());
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            base.Close();
            ModifyTimeForm mtf = new ModifyTimeForm();
            mtf.Show();
        }

        private void debitPayment_Click(object sender, EventArgs e)
        {
            base.Close();
            new MachinePayment
            {
                Text = "Debit Card Payment"
            }.Show();
        }

        private void creditPayment_Click(object sender, EventArgs e)
        {
            base.Close();
            new MachinePayment
            {
                Text = "Credit Card Payment"
            }.Show();
        }

        private void coinPayment_Click(object sender, EventArgs e)
        {
            base.Close();
            CoinPaymentForm cpf = new CoinPaymentForm();
            cpf.Show();
        }
    }
}
