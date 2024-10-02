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
        private void Form2_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();

        }
        public Form2()
        {
            InitializeComponent();
        }
        public void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateCrust();
            UpdateWhereToEat();
            UpdateToppings();
            UpdateTotalPrice();
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
            else
                MessageBox.Show("Update your order", "Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void ResetForm()
        {
            //Reset Groups
            gbSize.Enabled = true;
            gbCrustType.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;
            
            //Reset Size
            rbMedium.Checked = true;
            
            //Reset Toppings
            chkOnion.Checked = false;
            chkOlives.Checked = false;
            chkTomatoes.Checked = false;
            chkMushrooms.Checked = false;
            chkExtraChees.Checked = false;
            chkGreenPeppers.Checked = false;
          
            //Reset CrustType
            rbThinCrust.Checked = true;
           
            //Reset Where To Eat
            rbEatIn.Checked = true;
           
            //Reset Order Button
            btnOrderPizza.Enabled = true;
        }      

        float GetSelectedSizePrice()
        {
            if (rbSmall.Checked)
            {
                return Convert.ToSingle(rbSmall.Tag);
            }
            else if (rbMedium.Checked)
            {
                return Convert.ToSingle(rbMedium.Tag);
            }
            else
            {
                return Convert.ToSingle(rbLarge.Tag);
            }
        }
        float GetCalculateToppingsPrice()
        {
            float ToppingsTotalPrice = 0;

            if (chkOnion.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkOnion.Tag);
            }
            if(chkOlives.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkOlives.Tag);
            }
            if (chkTomatoes.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkTomatoes.Tag);
            }
            if (chkMushrooms.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkMushrooms.Tag);
            }
            if (chkExtraChees.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkExtraChees.Tag);
            }
            if (chkGreenPeppers.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkGreenPeppers.Tag);
            }
            return ToppingsTotalPrice;
        }
        float GetSelectedCrustPrice()
        {
            if (rbThinCrust.Checked)
            {
                return Convert.ToSingle(rbThinCrust.Tag);
            }
            else
            {
                return Convert.ToSingle(rbThinkCrust.Tag);
            }
        }

        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + GetCalculateToppingsPrice() + GetSelectedCrustPrice();
        }

        void UpdateTotalPrice()
        {
            lblTotalPrice.Text = "$" + CalculateTotalPrice().ToString();
        }

        void UpdateSize()
        {
            UpdateTotalPrice();

            if (rbSmall.Checked)
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

        void UpdateCrust()
        {
            UpdateTotalPrice();

            if (rbThinCrust.Checked)
            {
                lblCrustType.Text = "Thin Crust";
                return;
            }
            if (rbThinkCrust.Checked)
            {
                lblCrustType.Text = "Think Crust";
                return;
            }
        }
        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }
        private void rbThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        void UpdateWhereToEat()
        {
            if (rbEatIn.Checked)
            {
                lblWhereToEat.Text = "Eat In";
                return;
            }
            if (rbTakeOut.Checked)
            {
                lblWhereToEat.Text = "Take Out";
                return;
            }
        }
        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }
        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }
       
        void UpdateToppings()
        {
            UpdateTotalPrice();

            string sToppings = "";

            if (chkOnion.Checked)
            {
                sToppings += "Onion\n";
            }
            if (chkOlives.Checked)
            {
                sToppings += "Olives\n";
            }
            if (chkTomatoes.Checked)
            {
                sToppings += "Tomatoes\n";
            }
            if (chkMushrooms.Checked)
            {
                sToppings += "Mushrooms\n";
            }
            if (chkExtraChees.Checked)
            {
                sToppings += "ExtraChees\n";
            }
            if (chkGreenPeppers.Checked)
            {
                sToppings += "GreenPeppers\n";
            }
            if (sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1, sToppings.Length - 1).Trim();
            }
            if (sToppings == "")
                sToppings = "No Toppings";

            lblToppings.Text = sToppings;
        }
        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
