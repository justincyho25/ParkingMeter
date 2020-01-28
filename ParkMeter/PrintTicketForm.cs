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
    public partial class PrintTicketForm : Form
    {
        public PrintTicketForm()
        {
            InitializeComponent();
            this.printProgress.Visible = false;
        }

        private void printTicket_Click(object sender, EventArgs e)
        {
            this.printTicket.Visible = false;
            this.printProgress.Visible = true;
            this.print();
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
    }
}
