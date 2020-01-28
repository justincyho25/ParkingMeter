using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkMeter
{
    class Time
    {
        private static DateTime expiryTime = DateTime.Now;
        private static DateTime newExpiryTime = DateTime.Now;
        private static DateTime issueTime = DateTime.Now;

        public static void setExpiryTime(int newH, int newM)
        {
            TimeSpan t = new TimeSpan(0, newH, newM, 0);
            Time.newExpiryTime = DateTime.Now + t;
        }
        public static DateTime getExpiryTime()
        {
            return Time.newExpiryTime;
        }
        public static void setIssueTime(DateTime e)
        {
            Time.issueTime = e;
        }

        public static DateTime getIssueTime()
        {
            return Time.issueTime;
        }
    }
}
