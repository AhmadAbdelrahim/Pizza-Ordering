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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }         

        private void btn1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();   // Make Object from Form2 then Call Method from Form2
            frm2.ResetForm();
            frm2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
