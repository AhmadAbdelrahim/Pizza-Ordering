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
            lblSize.Text = "Small";
        }

        private void rdBtn2_CheckedChanged(object sender, EventArgs e)
        {
            lblSize.Text = "Medium";
        }

        private void rdBtn3_CheckedChanged(object sender, EventArgs e)
        {
            lblSize.Text = "Large";
        }

        private void rdBtn4_CheckedChanged(object sender, EventArgs e)
        {
            lblCrustType.Text = "Thin Crust";
        }

        private void rdBtn5_CheckedChanged(object sender, EventArgs e)
        {
            lblCrustType.Text = "Think Crust";
        }

        private void rdBtn6_CheckedChanged(object sender, EventArgs e)
        {
            lblWhereToEat.Text = "Eat In";
        }

        private void rdBtn7_CheckedChanged(object sender, EventArgs e)
        {
            lblWhereToEat.Text = "Take Out";
        }

        private void ckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(chkOnion.Checked)
            { 
                lblToppings.Text = "Onion"; 
            }
            else
            {
                lblToppings.Text = "No Toppings";
            }
        }

        private void ckBox2_CheckedChanged(object sender, EventArgs e)
        {            
            if (chkOnion.Checked)
            {
                lblToppings.Text = "Onion";
            }
            if (chkOnion.Checked && chkOlives.Checked)
            {
                lblToppings.Text = "Onion, Olives";
            }
            else if (chkOlives.Checked)
            {
                lblToppings.Text = "Olives";
            }
                
            else
            {
                lblToppings.Text = "No Toppings";
            }
        }

        private void ckBox3_CheckedChanged(object sender, EventArgs e)
        {            
            if(chkOnion.Checked && chkOlives.Checked && chkTomatoes.Checked)
            {
                lblToppings.Text = "Onion, Olives, Tomatoes";
            }
            else if (chkTomatoes.Checked)
            {
                lblToppings.Text = "Tomatoes";
            }
            else
            {
                lblToppings.Text = "No Toppings";
            }
        }

        private void ckBox4_CheckedChanged(object sender, EventArgs e)
        {            
            if (chkOnion.Checked && chkOlives.Checked && chkTomatoes.Checked && chkMushrooms.Checked)
            {
                lblToppings.Text = "Onion, Olives, Tomatoes, Mushrooms";
            }
            else if (chkMushrooms.Checked)
            {
                lblToppings.Text = "Mushrooms";
            }
            else
            {
                lblToppings.Text = "No Toppings";
            }
        }

        private void ckBox5_CheckedChanged(object sender, EventArgs e)
        {           
            if (chkOnion.Checked && chkOlives.Checked && chkTomatoes.Checked && chkMushrooms.Checked && chkExtraChees.Checked)
            {
                lblToppings.Text = "Onion, Olives, Tomatoes, Mushrooms, Extra Chees";
            }
            if (chkOnion.Checked && chkOlives.Checked && chkTomatoes.Checked && chkMushrooms.Checked && chkExtraChees.Checked)
            {
                lblToppings.Text = "Onion, Olives, Tomatoes, Mushrooms, Extra Chees, Green Peppers";
            }
            else if (chkOnion.Checked && chkOlives.Checked && chkTomatoes.Checked && chkMushrooms.Checked && chkGreenPeppers.Checked)
            {
                lblToppings.Text = "Onion, Olives, Tomatoes, Mushrooms, Green Peppers";
            }
            else if (chkExtraChees.Checked)
            {
                lblToppings.Text = "Extra Chees";
            }
            else
            {
                lblToppings.Text = "No Toppings";
            }
        }

        private void ckBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOnion.Checked && chkOlives.Checked && chkTomatoes.Checked && chkMushrooms.Checked && chkExtraChees.Checked && chkGreenPeppers.Checked)
            {                
                lblToppings.Text = "Onion, Olives, Tomatoes, Mushrooms, Extra Chees, Green Peppers";                
            }
            else if (chkOnion.Checked && chkOlives.Checked && chkTomatoes.Checked && chkMushrooms.Checked && chkExtraChees.Checked)
            {
                lblToppings.Text = "Onion, Olives, Tomatoes, Mushrooms, Extra Chees";
            }
            else if (chkGreenPeppers.Checked)
            {
                lblToppings.Text = "Green Peppers";
            }
            else
            {
                lblToppings.Text = "No Toppings";
            }
        }
    }
}
