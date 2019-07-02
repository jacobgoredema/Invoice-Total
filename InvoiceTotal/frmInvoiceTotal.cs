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
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal subtotal = Convert.ToDecimal(txtSubTotal.Text);
            decimal discountPercent = 0m;
            decimal discountAmount = 0m;
            decimal invoiceTotal = 0m;

            if (subtotal>=500)
            {
                discountPercent = .2m;
            }
            else if(subtotal>=250 && subtotal < 500)
            {
                discountPercent = .15m;
            }
            else if(subtotal>=100 && subtotal < 250)
            {
                discountPercent = .1m;
            }


            discountAmount = subtotal * discountPercent;
            invoiceTotal = subtotal - discountAmount;

            txtDiscountPercentage.Text = discountPercent.ToString("p1");
            txtDiscountAmount.Text = discountAmount.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");

            txtSubTotal.Focus();
        }
    }
}
