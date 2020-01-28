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
    public partial class ReturnTicketForm : Form
    {
        private int newHours;
        private int newMinutes;
        private int ticketNumber;

        public ReturnTicketForm(int n)
        {
            InitializeComponent();

            //since the list starts a 0, duh
            this.ticketNumber = n - 1;
            this.newHours = DateTime.Now.Hour;
            this.newMinutes = DateTime.Now.Minute;

            DateTime issueDate = Ticket.issueDateList.ElementAt(ticketNumber);
            DateTime now = DateTime.Now;
            TimeSpan difference = now.Subtract(issueDate);

            //Calculation of refund amount
            double refundAmount = Ticket.amountPaidList.ElementAt(ticketNumber) - Ticket.rateList.ElementAt(ticketNumber) * (difference.TotalHours);
            this.ticketNumberLabel.Text = "Ticket Number: " +(ticketNumber+1).ToString();
            this.refundAmountLabel.Text = Payment.formatMoney(refundAmount);
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            this.confirmButton.Visible = false;
            this.refundProgress.Visible = true;
            refund();
        }

        private void refund()
        {
            int num;
            for (int i = 1; i < 21; i = num + 1)
            {
                this.refundProgress.PerformStep();
                Thread.Sleep(100);
                num = i;
            }
            base.Close();
            ConfirmRefundForm crf = new ConfirmRefundForm();
            crf.Show();

        }
    }
}
