using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
//using System.Collections.Generic;
using System.Net;

namespace AnimalReport
{
    public partial class CusMain : Form
    {
        public CusMain()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            List<Customer> cus = new List<Customer>(); 

            foreach(var i in cus)
               // cus.Add(i) = new Customer(txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtDescription.Text, DateTime.Parse(txtBirthday.Text));
        }
    }
}