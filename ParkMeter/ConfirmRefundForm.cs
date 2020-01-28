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
    public partial class ConfirmRefundForm : Form
    {
        public ConfirmRefundForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            base.Close();
            HomeScreenForm hsf = new HomeScreenForm();
            hsf.Show();
        }
    }
}
