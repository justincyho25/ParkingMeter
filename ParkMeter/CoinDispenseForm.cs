using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ParkMeter
{
    public partial class CoinDispenseForm : Form
    {
        private double paid;

        public CoinDispenseForm(double p)
        {
            this.paid = p;
            double amountOwed = Payment.getAmountOwing();

            InitializeComponent();


            changeLabel.Text = "Dispensing Amount: "+Payment.formatMoney(paid-amountOwed);
        }

        private void print()
        {
            int num;
            for (int i = 1; i < 21; i = num + 1)
            {
                this.printProgress.PerformStep();
                Thread.Sleep(100);
                num = i;
            }
            base.Close();
            // PROBABLY NEED TO UPDATE THE TIME PURCHASED AND EXPIRY TIME HERE IN THE TIME C FILE
            HomeScreenForm hsf = new HomeScreenForm();
            hsf.Show();
            ParkingTicketForm ptf = new ParkingTicketForm();
            ptf.Show();
        }

        private void printTicketButton_Click(object sender, EventArgs e)
        {
            this.printTicketButton.Visible = false;
            this.printProgress.Visible = true;
            this.print();
        }
    }
}
