using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
using System.Net;

namespace AnimalReport
{
    public partial class CusMain : Form
    {
        public Customer[] CustomerArrary = new Customer[10];
        public int CustomerArrayIndex = 0;

        public CusMain()
        {
            InitializeComponent();
        }


        private void ShowDetail(Customer cus)
        {
            labelFrisstName.Text = cus.FirstName;
            labelLastName.Text = cus.LastName;
            labelAddress.Text = cus.Address;
        }

        private void BtnInput_Click(object sender, EventArgs e)
        {
            CustomerArrary[CustomerArrayIndex] = new Customer(txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtDescription.Text, DateTime.Parse(txtBirthday.Text));


            ListCustomer.Items.Add(CustomerArrary[CustomerArrayIndex].FirstName);
            CustomerArrayIndex++;
            /*
            for(int i = 0; i < custormerArrary20.Length; i++)
            {

            }
            */
            // cus.Add(i) = new Customer(txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtDescription.Text, DateTime.Parse(txtBirthday.Text));
        }

        private void ListCustomer_Click(object sender, EventArgs e)
        {
            string firstName;

            if (ListCustomer.SelectedItem.ToString() is not null)
            {
                firstName = ListCustomer.SelectedItem.ToString();
                for (int index = 0; index < CustomerArrayIndex; index++)
                {
                    if (CustomerArrary[index].FirstName == firstName)
                    {
                        ShowDetail(CustomerArrary[index]);
                        break;
                    }
                }
            }
        }
    }
}