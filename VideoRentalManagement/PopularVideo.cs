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
    public partial class PopularVideo : Form
    {
        SqldbContext tbl = new SqldbContext();
        public PopularVideo()
        {
            InitializeComponent();
        }

        private void PopularVideo_Load(object sender, EventArgs e)
        {
            BindPopularVideo();
        }
        private void BindPopularVideo()
        {
            DataTable dt = new DataTable();
            dt = tbl.BindPopularVideo();

            gridTopPopularVideo.DataSource = dt;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
