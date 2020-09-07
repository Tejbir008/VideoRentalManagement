using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRentalManagement
{
    public partial class AddCustomer : Form
    {
        SqldbContext tbl = new SqldbContext();
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            customerListBind();
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            
        }
        public void customerListBind()
        {
            DataTable dt = new DataTable();

            dt = tbl.customerListBind();
            gridAllCustomer.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_firstname.Text))
            {
                MessageBox.Show("First Name is required");
                return;
            }
            else if (string.IsNullOrEmpty(txt_lastname.Text))
            {
                MessageBox.Show("Last Name is required");
                return;
            }
            else if (string.IsNullOrEmpty(txt_address.Text))
            {
                MessageBox.Show("Address is required");
                return;
            }
            else if (string.IsNullOrEmpty(txt_phoneno.Text))
            {
                MessageBox.Show("Phone No. is required");
                return;
            }
            int cust = tbl.customerInsert(txt_firstname.Text, txt_lastname.Text, txt_address.Text, txt_phoneno.Text);
            if (cust == 1)
            {
                lblCustId.Text = "";

                ClearTextBoxes();
                customerListBind();

                MessageBox.Show("Successfully Add Customer");
                btnSave.Enabled = true;
                btnEdit.Enabled = false;
                btnDel.Enabled = false;
            }
            
        }
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

       
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

       

        private void gridAllCustomer_Click(object sender, EventArgs e)
        {
            if (gridAllCustomer.Rows.Count > 0)
            {
                lblCustId.Text = gridAllCustomer.CurrentRow.Cells[0].Value.ToString();
                txt_firstname.Text = gridAllCustomer.CurrentRow.Cells[1].Value.ToString();
                txt_lastname.Text = gridAllCustomer.CurrentRow.Cells[2].Value.ToString();
                txt_address.Text = gridAllCustomer.CurrentRow.Cells[3].Value.ToString();
                txt_phoneno.Text = gridAllCustomer.CurrentRow.Cells[4].Value.ToString();
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
                btnDel.Enabled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int custEdit = tbl.customerUpdate(txt_firstname.Text, txt_lastname.Text, txt_address.Text, txt_phoneno.Text, Convert.ToInt32(lblCustId.Text));
            if (custEdit == 1)
            {
                lblCustId.Text = "";

                ClearTextBoxes();
                customerListBind();

                MessageBox.Show("Successfully Update Customer");
                btnSave.Enabled = true;
                btnEdit.Enabled = false;
                btnDel.Enabled = false;
            }
           
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ARE YOU SURE YOU WANT TO DELETE THIS Customer ??", "Customer Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int cust = tbl.customerDelete(Convert.ToInt32(lblCustId.Text));
                if (cust == 1)
                {
                    lblCustId.Text = "";

                    ClearTextBoxes();
                    customerListBind();

                    MessageBox.Show("Successfully Delete Customer");

                    btnSave.Enabled = true;
                    btnEdit.Enabled = false;
                    btnDel.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Wrong Data Input");
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            lblCustId.Text = "";
            //txt_custno.Enabled = true;
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            customerListBind();
            txt_firstname.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
