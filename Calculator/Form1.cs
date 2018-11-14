using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class FormMain : Form
    {
        String totalValue = String.Empty;
        String firstValue = String.Empty;
        public FormMain()
        {
            InitializeComponent();
            txtDisplay.Text = "0";

        }


        private void btnNumberClick(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Equals("0"))
            {
                txtDisplay.Clear();
            }
            Button number = (Button)sender;
            totalValue += number.Text;
            txtDisplay.Text = totalValue;
        }


        private void btnCE_Click(object sender, EventArgs e)
        {
            totalValue = "0";
            txtDisplay.Text = totalValue;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            totalValue = "0";
            txtDisplay.Text = totalValue;
        }

        private void btbBack_Click(object sender, EventArgs e)
        {
            totalValue=totalValue.Remove(totalValue.Length-1, 1);
            txtDisplay.Text = totalValue;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
           
            if(!String.IsNullOrEmpty(firstValue))
            {
                Double val1 = Double.Parse(firstValue);
                Double val2 = Double.Parse(totalValue);
                Double res = val1 + val2;
                totalValue = res.ToString();
                txtDisplay.Text = totalValue;
                

            }else
            {
                firstValue = totalValue;
                totalValue = String.Empty;
              
            }
        }

       
    }
}
