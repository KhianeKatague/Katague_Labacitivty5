using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sison_Labact_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void OI_IpCOTbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmpDeptTbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void BI_IpCOTbx_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void BI_RpHTbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void BI_HpCOTbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double bi_ratephour, bi_numofhrs, bi_income, hi_ratephour, hi_numofhrs, hi_income, oi_ratephour, oi_numofhrs, oi_income;

            if (double.TryParse(BI_RpHTbx.Text, out bi_ratephour) &&
                double.TryParse(BI_HpCOTbx.Text, out bi_numofhrs) &&
                double.TryParse(HI_RpHTbx.Text, out hi_ratephour) &&
                double.TryParse(HI_HpCOTbx.Text, out hi_numofhrs) &&
                double.TryParse(OI_RpHTbx.Text, out oi_ratephour) &&
                double.TryParse(OI_HpCOTbx.Text, out oi_numofhrs)
                ) {

                bi_income = bi_ratephour * bi_numofhrs;
                hi_income = hi_ratephour * hi_numofhrs;
                oi_income = oi_ratephour * oi_numofhrs;
            
        }
    }
}
