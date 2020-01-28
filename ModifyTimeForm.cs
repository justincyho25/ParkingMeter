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
    public partial class ModifyTimeForm : Form
    {
        private int newHours;
        private int newMinutes;

        public ModifyTimeForm()
        {
            InitializeComponent();
            //In case you go back from payment screen, saves state from previous confirm click
            newHours = Payment.getHours();
            newMinutes = Payment.getMinutes();

            newHoursLabel.Text = newHours +" Hours";
            newMinLabel.Text = newMinutes + " Minutes";

            //Initially checks state, whether or not input has been made and sets the confirm button to be enabled or disabled
            if ((newHours == 0) && (newMinutes == 0))
            {
                this.confirmButton.Enabled = false;
            }
            else
            {
                this.confirmButton.Enabled = true;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            base.Close();
            HomeScreenForm hsf = new HomeScreenForm();
            hsf.Show();
        }

        private void hoursScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            this.newHours = this.hoursScrollBar.Maximum - this.hoursScrollBar.Value;
            updateTimeLabels();
            enableConfirm();
        }

        private void minutesScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            this.newMinutes = this.minutesScrollBar.Maximum - this.minutesScrollBar.Value;
            updateTimeLabels();
            enableConfirm();
        }

        private void enableConfirm()
        {
            //If no new hours or minutes are entered, disable confirm
            if((newHours == 0) && (newMinutes == 0))
            {
                this.confirmButton.Enabled = false;
            }
            else
            {
                this.confirmButton.Enabled = true;
            }
        }

        private void updateTimeLabels()
        {
            this.newHoursLabel.Text = this.newHours.ToString() + " Hours";
            this.newMinLabel.Text = this.newMinutes.ToString() + " Minutes";
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Payment.setHours(newHours);
            Payment.setMinutes(newMinutes);

            double amountOwing = Payment.getRate() * ((double)newHours + (double)newMinutes/60);
            Payment.setAmountOwing(amountOwing);
            base.Hide();
            PaymentForm pf = new PaymentForm();
            pf.Show();
        }
    }
}
