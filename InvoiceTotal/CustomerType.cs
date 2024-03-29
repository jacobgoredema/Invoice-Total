﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class CustomerType : Form
    {
        public CustomerType()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string customerType = txtCustomerType.Text;
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal discountPercentage = .0m;

            if (customerType=="R")
            {
                if (subtotal < 100)
                    discountPercentage = .0m;
                else if (subtotal >= 100 && subtotal < 250)
                    discountPercentage = 0.1m;
                else if (subtotal > 250)
                    discountPercentage = .25m;
            }
            else if (customerType=="C")
            {
                if (subtotal < 250)
                    discountPercentage = .2m;
                else
                    discountPercentage = .3m;
            }
            else
            {
                discountPercentage = .4m;
            }

            decimal discountAmount = subtotal * discountPercentage;
            decimal invoiceTotal = subtotal - discountAmount;

            txtDiscountPercentage.Text = discountPercentage.ToString("p1");
            txtDiscountAmount.Text = discountAmount.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");

            txtCustomerType.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
