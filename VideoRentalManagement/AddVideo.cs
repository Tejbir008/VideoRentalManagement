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
    public partial class AddVideo : Form
    {
        SqldbContext tbl = new SqldbContext();
        public AddVideo()
        {
            InitializeComponent();
        }

        private void AddVideo_Load(object sender, EventArgs e)
        {
            videoAllGet();
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            if (dtp_ReleaseDate.Value.Date <= DateTime.Now.Date.AddYears(-5))
            {
                txt_Cost.Text = "2";
            }
            else
            {
                txt_Cost.Text = "5";
            }
        }
        private void gridVideo_Click(object sender, EventArgs e)
        {
            if (gridVideo.Rows.Count > 0)
            {
                lblMovieId.Text = gridVideo.CurrentRow.Cells[0].Value.ToString();
                txt_Title.Text = gridVideo.CurrentRow.Cells[1].Value.ToString();
                dtp_ReleaseDate.Text = gridVideo.CurrentRow.Cells[2].Value.ToString();
                txt_Cost.Text = gridVideo.CurrentRow.Cells[3].Value.ToString();
                txt_Genre.Text = gridVideo.CurrentRow.Cells[4].Value.ToString();
                txt_Plot.Text = gridVideo.CurrentRow.Cells[5].Value.ToString();
                btnSave.Enabled = false;
                btnDel.Enabled = true;
                btnEdit.Enabled = true;

            }
        }
        public void videoAllGet()
        {
            DataTable dt = new DataTable();

            dt = tbl.videoAllGet();

            //custGrid.AutoGenerateColumns = false;
            gridVideo.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Title.Text))
            {
                MessageBox.Show("Movie Title is required");
                return;
            }
            else if (string.IsNullOrEmpty(txt_Cost.Text))
            {
                MessageBox.Show("Rental Cost is required");
                return;
            }

            int success = tbl.videoInsert(txt_Title.Text, dtp_ReleaseDate.Value.Date, Convert.ToDecimal(txt_Cost.Text), txt_Genre.Text, txt_Plot.Text);
            if (success == 1)
            {
                lblMovieId.Text = "";

                ClearTextBoxes();
                videoAllGet();

                MessageBox.Show("Successfully Add Movie");
                btnSave.Enabled = true;
                btnEdit.Enabled = false;
                btnDel.Enabled = false;
                if (dtp_ReleaseDate.Value.Date <= DateTime.Now.Date.AddYears(-5))
                {
                    txt_Cost.Text = "2";
                }
                else
                {
                    txt_Cost.Text = "5";
                }
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

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int success = tbl.videoUpdate(txt_Title.Text, dtp_ReleaseDate.Value.Date, Convert.ToDecimal(txt_Cost.Text), txt_Genre.Text, txt_Plot.Text, Convert.ToInt32(lblMovieId.Text));
            if (success == 1)
            {
                lblMovieId.Text = "";

                ClearTextBoxes();
                videoAllGet();

                MessageBox.Show("Successfully Update Movie");
                btnSave.Enabled = true;
                btnEdit.Enabled = false;
                btnDel.Enabled = false;
                if (dtp_ReleaseDate.Value.Date <= DateTime.Now.Date.AddYears(-5))
                {
                    txt_Cost.Text = "2";
                }
                else
                {
                    txt_Cost.Text = "5";
                }
            }
           
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ARE YOU SURE YOU WANT TO DELETE THIS Video ??", "Record Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int success = tbl.videoDelete(Convert.ToInt32(lblMovieId.Text));
                if (success == 1)
                {
                    lblMovieId.Text = "";

                    ClearTextBoxes();
                    videoAllGet();

                    MessageBox.Show("Successfully Delete Movie");
                    btnSave.Enabled = true;
                    btnEdit.Enabled = false;
                    btnDel.Enabled = false;
                    if (dtp_ReleaseDate.Value.Date <= DateTime.Now.Date.AddYears(-5))
                    {
                        txt_Cost.Text = "2";
                    }
                    else
                    {
                        txt_Cost.Text = "5";
                    }
                }
               
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void dtpReleaseDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_ReleaseDate.Value.Date <= DateTime.Now.Date.AddYears(-5))
            {
                txt_Cost.Text = "2";
            }
            else
            {
                txt_Cost.Text = "5";
            }
        }

        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            lblMovieId.Text = "";
            //txt_custno.Enabled = true;
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            videoAllGet();
            txt_Title.Focus();
            if (dtp_ReleaseDate.Value.Date <= DateTime.Now.Date.AddYears(-5))
            {
                txt_Cost.Text = "2";
            }
            else
            {
                txt_Cost.Text = "5";
            }
        }
    }
}
