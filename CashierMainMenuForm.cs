﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery_Store_Management_System_01
{
    public partial class CashierMainMenuForm : Form
    {
        public CashierMainMenuForm()
        {
            InitializeComponent();
        }

        private void POSSystemButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            POSSystem POSSystemObj = new POSSystem();
            POSSystemObj.ShowDialog();
        }
    }
}
