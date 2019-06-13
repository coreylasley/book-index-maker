using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BookIndexMaker
{
    public partial class License : Form
    {
        public License()
        {
            InitializeComponent();
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim() != "" && txtActivationCode.Text.Trim() != "")
            {
                if (Common.GetCode(txtEmail.Text) == txtActivationCode.Text)
                {
                    lblMode.Text = "Full Version";
                    lblMode.ForeColor = Color.Green;
                }
                else
                {
                    lblMode.Text = "DEMO";
                    lblMode.ForeColor = Color.Red;
                    MessageBox.Show("Invalid Activation Code!", "Opps");
                }
            }
            else
            {
                lblMode.Text = "DEMO";
                lblMode.ForeColor = Color.Red;
                MessageBox.Show("Invalid Activation Code!", "Opps");
            }
        }
    }
}
