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
    public partial class RentalReturnVideo : Form
    {
        SqldbContext tbl = new SqldbContext();
        SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["RentalDB"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        public RentalReturnVideo()
        {
            InitializeComponent();
        }

        private void Issue_ReturnVideo_Load(object sender, EventArgs e)
        {
            customerListBind();
            videoAllAvailable();
            RentedmovieGridData();
            radioAllrental.Checked = true;
        }
        private void customerListBind()
        {

            DataTable dt = new DataTable();

            dt = tbl.customerListBind();
            //if (dt.Rows.Count > 0)
            //{
            DataRow row = dt.NewRow();
            row[0] = 0;
            row[1] = "-- Select Customer --";
            dt.Rows.InsertAt(row, 0);
            combobox_Customer.DataSource = dt;
                combobox_Customer.ValueMember = "CustId";
                combobox_Customer.DisplayMember = "FirstName";

            //}
        }
        private void videoAllAvailable()
        {

            DataTable dt = new DataTable();

            dt = tbl.videoAllAvailable();
            //if (dt.Rows.Count > 0)
            //{
            DataRow row = dt.NewRow();
            row[0] = 0;
            row[1] = "-- Select Movie --";
            dt.Rows.InsertAt(row, 0);
            combobox_Video.DataSource = dt;
                combobox_Video.ValueMember = "MovieId";
                combobox_Video.DisplayMember = "Title";

            //}
        }

        private void btnRentalVideo_Click(object sender, EventArgs e)
        {
            if(combobox_Customer.SelectedValue==null || combobox_Video.SelectedValue==null)
            {
                MessageBox.Show("Please Select the Customer and Video");
                return;
            }
            if (combobox_Customer.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Customer");
                return;
            }
            if (combobox_Video.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Video");
                return;
            }
            if (string.IsNullOrEmpty(combobox_Customer.SelectedValue.ToString()) || string.IsNullOrEmpty(combobox_Video.SelectedValue.ToString()))
            {
                MessageBox.Show("Please Select the Customer and Movie for rental");
                return;
            }


            int success = tbl.videorentalInsert(Convert.ToInt32(combobox_Video.SelectedValue.ToString()), Convert.ToInt32(combobox_Customer.SelectedValue.ToString()), RentedDate.Value.Date);

            if (success == 1)
            {
                int chngeStatus = tbl.ChangedStatus(Convert.ToInt32(combobox_Video.SelectedValue.ToString()), "No");
                MessageBox.Show("Movie Rented successfully");
                customerListBind();
                videoAllAvailable();
                if (radioAllrental.Checked == true)
                {
                    RentedmovieGridData();
                }
                else
                {
                    RentedOutGridData();
                }

            }
            else
            {
                MessageBox.Show("Wrong Data Input");
            }
        }
        private void RentedmovieGridData()
        {
            DataTable dt = new DataTable();

            dt = tbl.viewRentedMovie();

            //custGrid.AutoGenerateColumns = false;
            gridViewrental.DataSource = dt;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void RentedOutGridData()
        {
            DataTable dt = new DataTable();

            dt = tbl.viewrentedOutMovie();

            //custGrid.AutoGenerateColumns = false;
            gridViewrental.DataSource = dt;
        }

       
        private void radioAllrental_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAllrental.Checked == true)
            {
                RentedmovieGridData();
            }
            else
            {
                RentedOutGridData();
            }
        }

        private void radioRentOut_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAllrental.Checked == true)
            {
                RentedmovieGridData();
            }
            else
            {
                RentedOutGridData();
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            if (gridViewrental.Rows.Count > 0)
            {
                rentalMovieId.Text = gridViewrental.CurrentRow.Cells["RMID"].Value.ToString();

                VideoId.Text = gridViewrental.CurrentRow.Cells["MovieId"].Value.ToString();
            }
            if (string.IsNullOrEmpty(rentalMovieId.Text))
            {
                MessageBox.Show("Select the Rented Video");
                return;
            }
            sqlcon.Open();
            var alreadyReturned = 0;
            cmd = new SqlCommand("Select * from RentedMovies where RentedMovieId=@RentedMovieId and DateReturned is Not NULL", sqlcon);
            cmd.Parameters.AddWithValue("@RentedMovieId", rentalMovieId.Text);
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                alreadyReturned = 1;
            }
            else
            {
                alreadyReturned = 0;
            }
            rdr.Close();
            sqlcon.Close();
            if (alreadyReturned == 1)
            {
                MessageBox.Show("Please Select the Not return Video");
                return;
            }


            int Success = tbl.movieReturned(Convert.ToInt32(rentalMovieId.Text));
            if (Success == 1)
            {
                int chngeStatus = tbl.ChangedStatus(Convert.ToInt32(VideoId.Text), "Yes");
                MessageBox.Show("Movie Returned successfully");
                VideoId.Text = "";
                rentalMovieId.Text = "";
                if (radioAllrental.Checked == true)
                {
                    RentedmovieGridData();
                }
                else
                {
                    RentedOutGridData();
                }
                customerListBind();
                videoAllAvailable();
            }
        }
    }
}
