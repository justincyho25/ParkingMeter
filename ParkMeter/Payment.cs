using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkMeter
{
    class Payment
    {
        private static double rate = 1.0;
        private static double amountOwing = 0;
        private static int hours = 0;
        private static int minutes = 0;

        public static void setRate(double r)
        {
            Payment.rate = r;
        }

        public static double getRate()
        {
            return Payment.rate;
        }

        public static string formatMoney(double i)
        {
            return "$" + string.Format("{0:0.00}", i);
        }

        public static double timeToCash(int hours, int minutes)
        {
            return Payment.rate * ((double)hours + (double)minutes / 60.0);
        }

        //TESTING STUFF
        public static void setAmountOwing(double a)
        {
            Payment.amountOwing = a;
        }
        public static double getAmountOwing()
        {
            return Payment.amountOwing;
        }
        public static void setHours(int h)
        {
            Payment.hours = h;
        }

        public static int getHours()
        {
            return Payment.hours;
        }

        public static void setMinutes(int m)
        {
            Payment.minutes = m;
        }

        public static int getMinutes()
        {
            return Payment.minutes;
        }
    }
}
