using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/**************************************
 * Name: Larry Mumford
 * Date: 2026-02-08
 * Description: CSC240_Exponents_startup_LDM
 *************************************/

namespace Exponents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            // STORAGE

            // INPUT

            // PROCESS
            /* calculate the square of the number and add it to the output - 
             * do this with a method call that allows you to pass the number
             * and then receive the answer */

            /* calculate the cube of the number and add it to the output - 
             * do this by creating a methd as in the squaring example above */

            // OUTPUT
            // set the output to visible

            // turn the Go button off
            // STORAGE
            int number;

            // INPUT
            if (!int.TryParse(this.txtInput.Text.Trim(), out number))
            {
                MessageBox.Show("Please enter a valid integer.", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtInput.Focus();
                return;
            }

            // PROCESS
            int squared = Square(number);
            int cubed = Cube(number);

            // OUTPUT
            this.lblOutput.Text = string.Format("Number: {0}\r\nSquare: {1}\r\nCube: {2}",
                number, squared, cubed);
            this.lblOutput.Visible = true;

            // turn the Go button off
            this.btnGo.Enabled = false;
        }

        public int Square(int num)
        {
            return num * num;
        }

        public int Cube(int num)
        {
            return num * num * num;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // the input and output text should be emptied
            this.txtInput.Text = string.Empty;
            this.lblOutput.Text = string.Empty;

            // turn the output to invisible
            this.lblOutput.Visible = false;

            // turn the Go button back on
            this.btnGo.Enabled = true;

            this.txtInput.Focus();
        }

    }
}
