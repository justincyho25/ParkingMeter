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
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.machineDisplay.Text.Length < 4 && this.machineDisplay.Text.Length > 0)
            {
                this.machineDisplay.Text = this.machineDisplay.Text + "1";
                this.errorLabel.Text = "";
            }
            else
            {
                if(this.machineDisplay.Text == "ENTER ADMIN PASSWORD")
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
                this.machineDisplay.Text = this.machineDisplay.Text + "2";
                this.errorLabel.Text = "";
            }
            else
            {
                if (this.machineDisplay.Text == "ENTER ADMIN PASSWORD")
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
                this.machineDisplay.Text = this.machineDisplay.Text + "3";
                this.errorLabel.Text = "";
            }
            else
            {
                if (this.machineDisplay.Text == "ENTER ADMIN PASSWORD")
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
                this.machineDisplay.Text = this.machineDisplay.Text + "4";
                this.errorLabel.Text = "";
            }
            else
            {
                if (this.machineDisplay.Text == "ENTER ADMIN PASSWORD")
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
                this.machineDisplay.Text = this.machineDisplay.Text + "5";
                this.errorLabel.Text = "";
            }
            else
            {
                if (this.machineDisplay.Text == "ENTER ADMIN PASSWORD")
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
                this.machineDisplay.Text = this.machineDisplay.Text + "6";
                this.errorLabel.Text = "";
            }
            else
            {
                if (this.machineDisplay.Text == "ENTER ADMIN PASSWORD")
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
                this.machineDisplay.Text = this.machineDisplay.Text + "7";
                this.errorLabel.Text = "";
            }
            else
            {
                if (this.machineDisplay.Text == "ENTER ADMIN PASSWORD")
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
                this.machineDisplay.Text = this.machineDisplay.Text + "8";
                this.errorLabel.Text = "";
            }
            else
            {
                if (this.machineDisplay.Text == "ENTER ADMIN PASSWORD")
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
                this.machineDisplay.Text = this.machineDisplay.Text + "9";
                this.errorLabel.Text = "";
            }
            else
            {
                if (this.machineDisplay.Text == "ENTER ADMIN PASSWORD")
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
                this.machineDisplay.Text = this.machineDisplay.Text + "0";
                this.errorLabel.Text = "";
            }
            else
            {
                if (this.machineDisplay.Text == "ENTER ADMIN PASSWORD")
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
            if (this.machineDisplay.Text.Length <= 4 && this.machineDisplay.Text.Length > 1)
            {
                this.machineDisplay.Text = this.machineDisplay.Text.Remove(this.machineDisplay.Text.Length - 1);
                this.errorLabel.Text = "";
            }
            else
            {
                this.machineDisplay.Text = "ENTER ADMIN PASSWORD";
                this.errorLabel.Text = "";
            }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if(this.machineDisplay.Text == "1111")
            {
                base.Close();
                AdminForm af = new AdminForm();
                af.Show();
            }
            else
            {
                this.errorLabel.Text = "INCORRECT ADMIN PASSWORD";
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            base.Close();
            HomeScreenForm hsf = new HomeScreenForm();
            hsf.Show();
        }
    }
}
