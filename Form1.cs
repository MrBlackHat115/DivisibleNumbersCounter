using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firstapplication
{
    public partial class Form1 : Form
    {
        private int divisibleTerm = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBold.Checked)
            {
                txtDivisibleNumbers.Font = new Font(txtDivisibleNumbers.Font, FontStyle.Bold);
            }
            else
            {
                txtDivisibleNumbers.Font = new Font(txtDivisibleNumbers.Font, FontStyle.Regular);
            }
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (chkItalic.Checked)
            {
                txtDivisibleNumbers.Font = new Font(txtDivisibleNumbers.Font, FontStyle.Italic);
            }
            else
            {
                txtDivisibleNumbers.Font = new Font(txtDivisibleNumbers.Font, FontStyle.Regular);
            }
        }

        private void rbBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBlack.Checked)
                txtDivisibleNumbers.ForeColor = System.Drawing.Color.Black;
        }

        private void rbRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRed.Checked)
                txtDivisibleNumbers.ForeColor = System.Drawing.Color.Red;
        }

        private void rbBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBlue.Checked)
                txtDivisibleNumbers.ForeColor = System.Drawing.Color.Blue;
        }

        private void rbGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGreen.Checked)
                txtDivisibleNumbers.ForeColor = System.Drawing.Color.Green;
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            if (txtStartFrom.Text == "" || txtTo.Text == "")
            {
                MessageBox.Show("Please fill the necessary fields.");
                return;
            }

            if (cmbDivisibleTerm.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a divisible term.");
                return;
            }

            int firstNumber = Convert.ToInt32(txtStartFrom.Text);
            int lastNumber = Convert.ToInt32(txtTo.Text);

            string divisibleNumbers = "";
            int controlNumber = 0;

            for (int i = firstNumber; i <= lastNumber; i++)
            {
                if (i % divisibleTerm == 0)
                {
                    divisibleNumbers += i + " ";
                    controlNumber++;

                    // After every 10 numbers, move to a new line
                    if (controlNumber % 10 == 0)
                    {
                        divisibleNumbers += Environment.NewLine;
                    }
                }
            }

            txtDivisibleNumbers.Text = divisibleNumbers;
        }

        private void txtStartFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and Backspace
            bool isDigit = char.IsDigit(e.KeyChar);
            bool isBackspace = e.KeyChar == (char)Keys.Back;

            if (!isDigit && !isBackspace)
            {
                // Block the key press
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDivisibleTerm.Items.Add(2);
            cmbDivisibleTerm.Items.Add(3);
            cmbDivisibleTerm.Items.Add(4);
            cmbDivisibleTerm.Items.Add(5);
            cmbDivisibleTerm.Items.Add(6);
            cmbDivisibleTerm.Items.Add(7);
            cmbDivisibleTerm.Items.Add(8);
            cmbDivisibleTerm.Items.Add(10);
        }

        private void cmbDivisibleTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            divisibleTerm = Convert.ToInt32(cmbDivisibleTerm.SelectedItem);
        }
    }
}