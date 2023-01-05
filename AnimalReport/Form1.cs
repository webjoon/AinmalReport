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
            //List<int> intListTest = new List<int>();

            CustomerArrary[CustomerArrayIndex] = new Customer(txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtDescription.Text, DateTime.Parse(txtBirthday.Text));


            ListCustomer.Items.Add(CustomerArrary[CustomerArrayIndex].FirstName);
            CustomerArrayIndex++;
            
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

        private void CusMain_Load(object sender, EventArgs e)
        {
            CusListBoxPanel.Dock = DockStyle.Left;
            DescPanel.Dock = DockStyle.Right;
            CusInputPanel.Dock = DockStyle.Right;
            CusInputPanel.Visible = false;
        }

        private void inputCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CusInputPanel.Visible = true;
            DescPanel.Visible = false;
        }
    }
}