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
    public partial class AdminForm : Form
    {
        private int newDollars;
        private int newCents;

        public AdminForm()
        {
            this.newDollars = 0;
            this.newCents = 0;

            InitializeComponent();
        }

        private void dollarScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            this.newDollars = this.dollarScrollBar.Maximum - this.dollarScrollBar.Value;
            this.updateRateLabels();
        }

        private void centsScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            this.newCents = this.centsScrollBar.Maximum - this.centsScrollBar.Value;
            this.updateRateLabels();
        }

        private void updateRateLabels()
        {
            this.newDollarsLabel.Text = "$ " + this.newDollars.ToString("00");
            this.newCentsLabel.Text = ". " + this.newCents.ToString("00");
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Payment.setRate((double)this.newDollars + 0.01 * (double)this.newCents);
            base.Close();
            HomeScreenForm hsf = new HomeScreenForm();
            hsf.Show();
        }
    }
}
