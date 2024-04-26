using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

/**************************************
 * Name:    Nate Swenson
 * Date:    4/25/2024
 * Description: A program using user-created method
 *              for the math function Square and Cube
 * Assistance:https://stackoverflow.com/questions/4107955/disable-and-enable-buttons-in-c-sharp
 * 
 *************************************/

namespace Exponents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void xGoButton_Click(object sender, EventArgs e)
        {
           
            if (int.TryParse(uxInputTextBox.Text, out int input))

            {

                int squared = Square(input);
                xOutputLabel.Text = $"The square of the number is {squared}";

                int cubed = Cube(input);

                xOutputLabel.Text += $"\nThe cube of the number is {cubed}";
            }

            else
            {
                xOutputLabel.Text = "Not an integer";

            }
            // OUTPUT
            xOutputLabel.Visible = true;    // set the output to visible

            xGoButton.Enabled = false;      // turn the Go button off
        }

        public int Square(int num)
        {
            return num * num; 
        }

        public int Cube(int num)
        {
            return num * num * num;
        }

        private void xResetButton_Click(object sender, EventArgs e)
        {
            uxInputTextBox.Text = null;
            xOutputLabel.Text = null; // the input and output text should be emptied
            
            xOutputLabel.Visible = false;    // turn the output to invisible
            
            xGoButton.Enabled = true;   // turn the Go button back on
        }

    }
}
