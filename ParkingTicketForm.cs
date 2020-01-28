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

            //Text Send Message
            Time.setExpiryTime(Payment.getHours(), Payment.getMinutes());
            string Coincheck = CoinDispenseForm.printPhoneNumber;
            string Cardcheck = PrintTicketForm.printPhoneNumber;
            string Cardpart = CoinDispenseForm.Cardcheck;

            //Coin check 
            if (Coincheck==null)
            {
                //get phone number from CoinDispenseForm
                TextSend.Text = " ";

            }
            else
            {
                string phoneNumber = CoinDispenseForm.phoneNumber;
                TextSend.Text = "Text will be Sent at : " + Time.getExpiryTime().AddMinutes(-10).ToString() + " to " + phoneNumber;
                
            }

            // gets sysdate for comparing
            DateTime Sysdate=DateTime.Now;

            if ((Cardcheck.Equals("yes") ||Coincheck.Equals("yes"))&& (Sysdate== Time.getExpiryTime().AddMinutes(-10)))
            {
                MessageBox.Show("your parking ticket will expire in 10 minutes");
            }

            //Card check
            if (Cardcheck.Equals("yes"))
            {
                //get phone number from CoinDispenseForm
                string phoneNumber = PrintTicketForm.phoneNumber;
                TextSend.Text = "Text will be Sent at : " + Time.getExpiryTime().AddMinutes(-10).ToString() + " to " + phoneNumber;
            }
            else
            {
                TextSend.Text = " ";
            }


            //RESET NEW HOURS AND NEW MINUTES FROM MODIFY FORM
            Payment.setHours(0);
            Payment.setMinutes(0);

           
        }
    }
}
