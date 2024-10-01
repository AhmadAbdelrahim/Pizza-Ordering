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
        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                btnOrderPizza.Enabled = false;
                gbSize.Enabled = false;
                gbCrustType.Enabled = false;
                gbToppings.Enabled = false;
                gbWhereToEat.Enabled = false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            gbSize.Enabled = true;
            gbCrustType.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;
        }

        void UpdateSize()
        {
            if(rbSmall.Checked)
            {
                lblSize.Text = "Small";
                return;
            }
            if(rbMedium.Checked)
            {
                lblSize.Text = "Medium";
                return;
            }
            if (rbLarge.Checked)
            {
                lblSize.Text = "Large";
                return;
            }
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }
        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }
        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }
        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            lblCrustType.Text = "Thin Crust";
        }
        private void rbThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            lblCrustType.Text = "Think Crust";
        }
        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            lblWhereToEat.Text = "Eat In";
        }
        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            lblWhereToEat.Text = "Take Out";
        }
        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOnion.Checked)
            {
                lblToppings.Text = "Onion";
            }
            else
            {
                lblToppings.Text = "No Toppings";
            }
        }
        private void chkOlives_CheckedChanged(object sender, EventArgs e)
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
        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOnion.Checked && chkOlives.Checked && chkTomatoes.Checked)
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
        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
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
        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
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
        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
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
        private void lblSize_Click(object sender, EventArgs e)
        {

        }
        private void lblToppings_Click(object sender, EventArgs e)
        {

        }
        private void lblCrustType_Click(object sender, EventArgs e)
        {

        }
        private void lblWhereToEat_Click(object sender, EventArgs e)
        {

        }
        private void lblTotalPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
