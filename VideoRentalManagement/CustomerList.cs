using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRentalManagement 
{
    public partial class CustomerList : Form
    {
        SqldbContext tbl = new SqldbContext();
        public CustomerList()
        {
            InitializeComponent();
        }

        private void RegularCustomer_Load(object sender, EventArgs e)
        {
            MostComeCustomer();
        }
        private void MostComeCustomer()
        {
            DataTable dt = new DataTable();
            dt = tbl.MostComeCustomer();

            gridTopCustomer.DataSource = dt;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
