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
    public partial class InsertTicketForm : Form
    {
        public InsertTicketForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            base.Close();
            HomeScreenForm hsf = new HomeScreenForm();
            hsf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.machineDisplay.Text.Length < 4 && this.machineDisplay.Text.Length >0)
            {
                this.errorLabel.Text = "";
                this.machineDisplay.Text = this.machineDisplay.Text + "1";
            }
            else
            {
                if(this.machineDisplay.Text == "ENTER TICKET NUMBER")
                {
                    this.machineDisplay.Text = "1";
                    this.errorLabel.Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.machineDisplay.Text.Length < 4 && this.machineDisplay.Text.Length > 0)
            {
                this.errorLabel.Text = "";
                this.machineDisplay.Text = this.machineDisplay.Text + "2";
            }
            else
            {
                if (this.machineDisplay.Text == "ENTER TICKET NUMBER")
                {
                    this.machineDisplay.Text = "2";
                    this.errorLabel.Text = "";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.machineDisplay.Text.Length < 4 && this.machineDisplay.Text.Length > 0)
            {
                this.errorLabel.Text = "";
                this.machineDisplay.Text = this.machineDisplay.Text + "3";
            }
            else
            {
                if (this.machineDisplay.Text == "ENTER TICKET NUMBER")
                {
                    this.machineDisplay.Text = "3";
                    this.errorLabel.Text = "";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.machineDisplay.Text.Length < 4 && this.machineDisplay.Text.Length > 0)
            {
                this.errorLabel.Text = "";
                this.machineDisplay.Text = this.machineDisplay.Text + "4";
            }
            else
            {
                if (this.machineDisplay.Text == "ENTER TICKET NUMBER")
                {
                    this.machineDisplay.Text = "4";
                    this.errorLabel.Text = "";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.machineDisplay.Text.Length < 4 && this.machineDisplay.Text.Length > 0)
            {
                this.errorLabel.Text = "";
                this.machineDisplay.Text = this.machineDisplay.Text + "5";
            }
            else
            {
                if (this.machineDisplay.Text == "ENTER TICKET NUMBER")
                {
                    this.machineDisplay.Text = "5";
                    this.errorLabel.Text = "";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.machineDisplay.Text.Length < 4 && this.machineDisplay.Text.Length > 0)
            {
                this.errorLabel.Text = "";
                this.machineDisplay.Text = this.machineDisplay.Text + "6";
            }
            else
            {
                if (this.machineDisplay.Text == "ENTER TICKET NUMBER")
                {
                    this.machineDisplay.Text = "6";
                    this.errorLabel.Text = "";
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.machineDisplay.Text.Length < 4 && this.machineDisplay.Text.Length > 0)
            {
                this.errorLabel.Text = "";
                this.machineDisplay.Text = this.machineDisplay.Text + "7";
            }
            else
            {
                if (this.machineDisplay.Text == "ENTER TICKET NUMBER")
                {
                    this.machineDisplay.Text = "7";
                    this.errorLabel.Text = "";
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (this.machineDisplay.Text.Length < 4 && this.machineDisplay.Text.Length > 0)
            {
                this.errorLabel.Text = "";
                this.machineDisplay.Text = this.machineDisplay.Text + "8";
            }
            else
            {
                if (this.machineDisplay.Text == "ENTER TICKET NUMBER")
                {
                    this.machineDisplay.Text = "8";
                    this.errorLabel.Text = "";
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (this.machineDisplay.Text.Length < 4 && this.machineDisplay.Text.Length > 0)
            {
                this.errorLabel.Text = "";
                this.machineDisplay.Text = this.machineDisplay.Text + "9";
            }
            else
            {
                if (this.machineDisplay.Text == "ENTER TICKET NUMBER")
                {
                    this.machineDisplay.Text = "9";
                    this.errorLabel.Text = "";
                }
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (this.machineDisplay.Text.Length < 4 && this.machineDisplay.Text.Length > 0)
            {
                this.errorLabel.Text = "";
                this.machineDisplay.Text = this.machineDisplay.Text + "0";
            }
            else
            {
                if (this.machineDisplay.Text == "ENTER TICKET NUMBER")
                {
                    this.machineDisplay.Text = "0";
                    this.errorLabel.Text = "";
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            base.Close();
            HomeScreenForm hsf = new HomeScreenForm();
            hsf.Show();
        }

        private void correctionButton_Click(object sender, EventArgs e)
        {
            if (this.machineDisplay.Text.Length < 4 && this.machineDisplay.Text.Length > 1)
            {
                this.machineDisplay.Text = this.machineDisplay.Text.Remove(this.machineDisplay.Text.Length - 1);
                this.errorLabel.Text = "";
            }
            else
            {
                this.machineDisplay.Text = "ENTER TICKET NUMBER";
                this.errorLabel.Text = "";
            }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if ((this.machineDisplay.Text.Length >= 1) && Ticket.ticketNumberList.Contains(Int32.Parse(this.machineDisplay.Text)))
            {
                int tickNumber;
                tickNumber = Int32.Parse(this.machineDisplay.Text);

                //Remove the ticket from the system
                Ticket.ticketNumberList.RemoveAt(tickNumber-1);
                Ticket.ticketNumberList.Insert(tickNumber-1, null);

                base.Close();
                ReturnTicketForm rtf = new ReturnTicketForm(tickNumber);
                rtf.Show();
            }
            else
            {
                this.errorLabel.Text = "INVALID TICKET NUMBER";
            }
        }

        private void InsertTicketForm_Load(object sender, EventArgs e)
        {

        }
    }
}
