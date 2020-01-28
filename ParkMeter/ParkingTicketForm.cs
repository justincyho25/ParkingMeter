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
    public partial class ParkingTicketForm : Form
    {
        public ParkingTicketForm()
        {
            InitializeComponent();

            //Set Parking Ticket Issue Date/Time and Expiry Date/Time

            //SET TICKET NUMBER
            Ticket.tick();
            ticketNumber.Text = "Ticket Number:" + Ticket.getTicketNumber().ToString();
            //SET ISSUE TIME 
            Time.setIssueTime(DateTime.Now);
            issueDate.Text = "Issue Date/Time:" + Time.getIssueTime().ToString();
            //SET EXPIRY TIME
            Time.setExpiryTime(Payment.getHours(), Payment.getMinutes());
            expiryDate.Text = "Expiry Date/Time:" +Time.getExpiryTime().ToString();

            //SET AMOUNT PAID
            amountPaid.Text = "Amount Paid: " + Payment.formatMoney(Payment.getAmountOwing());

            //RESET NEW HOURS AND NEW MINUTES FROM MODIFY FORM
            Payment.setHours(0);
            Payment.setMinutes(0);
        }
    }
}
