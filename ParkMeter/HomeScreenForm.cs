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
    public partial class HomeScreenForm : Form
    {
        public HomeScreenForm()
        {
            InitializeComponent();
            updateRateLabel();
        }

        private void purchaseTicket_Click(object sender, EventArgs e)
        {
            base.Hide();
            ModifyTimeForm mtf = new ModifyTimeForm();
            mtf.Show();
        }

        private void returnTicket_Click(object sender, EventArgs e)
        {
            base.Hide();
            InsertTicketForm itf = new InsertTicketForm();
            itf.Show();
        }

        private void administrator_Click(object sender, EventArgs e)
        {
            base.Hide();
            PasswordForm pf = new PasswordForm();
            pf.Show();
        }

        public void updateRateLabel()
        {
            this.rateLabel.Text = Payment.formatMoney(Payment.getRate()) + " / Hour";
        }
    }
}
