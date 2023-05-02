using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Running_Total
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int running_total = 0;
        //create a global running total and set it to start at 0
        int shims = 0;
        //create a global variable to keep track of number of items added
        int value;
        private void button1_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrEmpty(textBox1.Text)) 
            {
               
            }
            else
            {
                value = Convert.ToInt32(textBox1.Text);
                running_total = running_total + value;
                shims = shims + 1;
                textBox1.Clear();
                //takes the value in the text box and adds it to the running total. Then it clears the textbox of all entries
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Running total is: " +  running_total.ToString() + " lbs");
            MessageBox.Show("Number of Shims Added: " +  shims.ToString() + " shims");
            //creates a message box that displays the current running total
        }

        private void button3_Click(object sender, EventArgs e)
        {
            running_total = 0;
            shims = 0;
            //pressing this button resets the running total to 0 in case of errors or the user wants to do another calculation.
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            running_total = running_total - value;
            shims = shims - 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.Show();
            
        }
    }
}
