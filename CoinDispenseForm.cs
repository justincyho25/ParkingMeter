﻿using System;
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
        static public string phoneNumber;
        static public string printPhoneNumber;
        static public string Cardcheck;

        public CoinDispenseForm(double p)
        {
            this.paid = p;
            double amountOwed = Payment.getAmountOwing();

            InitializeComponent();


            changeLabel.Text = "Dispensing Amount: "+Payment.formatMoney(paid-amountOwed);
            PhoneNumber.ReadOnly = true;
            PhoneNumber.Enabled = false;
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
            phoneNumber = PhoneNumber.Text;
            if (checkBox1.Checked)
            {
                printPhoneNumber = "yes";
            }

            else
            {
                printPhoneNumber = "no";
            }
            Cardcheck = "no";
            this.print();
        }
        //Changes color of PhoneNumber box
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            PhoneNumber.BackColor = System.Drawing.Color.White;
            PhoneNumber.ReadOnly=false;
            PhoneNumber.Enabled = true;
            PhoneNumber.ForeColor = System.Drawing.Color.Black;
        }

        private void PhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
