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
using Oracle.ManagedDataAccess.Client;

namespace AnimalReport
{
    public partial class CusMain : Form
    {
        public Customer[] CustomerArrary = new Customer[10];
        public int CustomerArrayIndex = 0;
        OracleConnection pgOraConn;
        OracleCommand pgOraCmd;

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
            dataGridView1.Rows.Add(CustomerArrary[CustomerArrayIndex].FirstName, CustomerArrary[CustomerArrayIndex].LastName, CustomerArrary[CustomerArrayIndex].Agee);
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

            ConnectionDB("210.110.80.136", "ngt", "ngtdba", "ngtdba");
        }

        private void inputCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CusInputPanel.Visible = true;
            DescPanel.Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            CusInputPanel.Visible = false;
            DescPanel.Visible = true;
            labelFrisstName.Text = (string)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            labelLastName.Text = (string)dataGridView1.Rows[e.RowIndex].Cells[1].Value; 
            labelBirthday.Text = (string)dataGridView1.Rows[e.RowIndex].Cells[2].Value;
            labelAddress.Text = (string)dataGridView1.Rows[e.RowIndex].Cells[3].Value;
            labelDescription.Text = (string)dataGridView1.Rows[e.RowIndex].Cells[4].Value;
        }

        private bool ConnectionDB(string dbIp, string dbName, string dbId, string dbPw)
        {
            bool retValue = false;
            try
            {
                pgOraConn = new OracleConnection($"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={dbIp})(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={dbName})));User ID={dbId};Password={dbPw};Connection Timeout=15;");
                pgOraConn.Open();
                pgOraCmd = pgOraConn.CreateCommand();
                MessageBox.Show("Success DB Connection", "Information");

                retValue = true;
            }
            catch (Exception e)
            {
                retValue = false;
                MessageBox.Show($"DB Connection fail. \n {e.Message}", "Error");
            }

            return retValue;
        }
    }
}