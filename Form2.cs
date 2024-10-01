using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Ordering
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                {
                    MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    button1.Enabled = false;
                    gpBox1.Enabled = false;
                    gpBox2.Enabled = false;
                    gpBox3.Enabled = false;
                    gpBox4.Enabled = false;
                }
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gpBox1.Enabled = true;
            gpBox2.Enabled = true;
            gpBox3.Enabled = true;
            gpBox4.Enabled = true;
        }

        private void rdBtn1_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "Small";
        }

        private void rdBtn2_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "Medium";
        }

        private void rdBtn3_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "Large";
        }

        private void rdBtn4_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Thin Crust";
        }

        private void rdBtn5_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Think Crust";
        }

        private void rdBtn6_CheckedChanged(object sender, EventArgs e)
        {
            label9.Text = "Eat In";
        }

        private void rdBtn7_CheckedChanged(object sender, EventArgs e)
        {
            label9.Text = "Take Out";
        }

        private void ckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(ckBox1.Checked)
            { 
                label7.Text = "Onion"; 
            }
            else
            {
                label7.Text = "No Toppings";
            }
        }

        private void ckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBox2.Checked)
            {
                label7.Text = "Olives";
            }
            else if (ckBox1.Checked && ckBox2.Checked)
            {
                label7.Text = "Onion, Olives";
            }
            else
            {
                label7.Text = "No Toppings";
            }
        }

        private void ckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBox3.Checked)
            {
                label7.Text = "Tomatoes";
            }
            else if(ckBox1.Checked && ckBox2.Checked && ckBox3.Checked)
            {
                label7.Text = "Onion, Olives, Tomatoes";
            }
            else
            {
                label7.Text = "No Toppings";
            }
        }

        private void ckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBox4.Checked)
            {
                label7.Text = "Mushrooms";
            }
            else if (ckBox1.Checked && ckBox2.Checked && ckBox3.Checked && ckBox4.Checked)
            {
                label7.Text = "Onion, Olives, Tomatoes, Mushrooms";
            }
            else
            {
                label7.Text = "No Toppings";
            }
        }

        private void ckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBox5.Checked)
            {
                label7.Text = "Extra Chees";
            }
            else if (ckBox1.Checked && ckBox2.Checked && ckBox3.Checked && ckBox4.Checked && ckBox5.Checked)
            {
                label7.Text = "Onion, Olives, Tomatoes, Mushrooms, Extra Chees";
            }
            else
            {
                label7.Text = "No Toppings";
            }
        }

        private void ckBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBox6.Checked)
            {
                label7.Text = "Green Peppers";
            }
            else if (ckBox1.Checked && ckBox2.Checked && ckBox3.Checked && ckBox4.Checked && ckBox5.Checked && ckBox6.Checked)
            {                
                label7.Text = "Onion, Olives, Tomatoes, Mushrooms, Extra Chees, Green Peppers";                
            }
            else
            {
                label7.Text = "No Toppings";
            }
        }

    }
}
