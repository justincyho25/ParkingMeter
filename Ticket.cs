using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkMeter
{
    class Ticket
    {
        private static int count = 0;
        private static int tickNumber;

        //Set lists for Parking ticket information such as (Parking ticket number, issue date, expiry date, amount paid)
        public static List<int?> ticketNumberList = new List<int?>();
        public static List<DateTime> issueDateList = new List<DateTime>();
        public static List<DateTime> expiryDateList = new List<DateTime>();
        public static List<double> amountPaidList = new List<double>();
        public static List<double> rateList = new List<double>();


        public static void tick()
        {
            if (Ticket.count < 100)
            {
                Ticket.count++;
            }
            else
            {
                Ticket.count = 0;
            }
            setTicketNumber(count);
            ticketNumberList.Add(count);
            issueDateList.Add(Time.getIssueTime());
            expiryDateList.Add(Time.getExpiryTime());
            amountPaidList.Add(Payment.getAmountOwing());
            rateList.Add(Payment.getRate());
        }

        public static void setTicketNumber(int n)
        {
            Ticket.tickNumber = n;
        }
        public static int getTicketNumber()
        {
            return Ticket.tickNumber;
        }
    }
}
