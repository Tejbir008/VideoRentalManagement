using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRentalManagement
{
   public class SqldbContext
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["RentalDB"].ConnectionString);

        public int movieReturned(int moviereturn_Id)
        {

            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("update RentedMovies set DateReturned=@DateReturned where RentedMovieId=@RentedMovieId", con))
                {
                    cmd.Parameters.AddWithValue("@RentedMovieId", moviereturn_Id);
                    cmd.Parameters.AddWithValue("@DateReturned", DateTime.Now);

                    cmd.ExecuteNonQuery();

                }
                con.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int videorentalInsert(int movie_Id, int cust_Id, DateTime rented_Date)
        {

            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("insert into RentedMovies(MovieId,CustId,DateRented)values(@MovieId,@CustId,@DateRented)", con))
                {
                    cmd.Parameters.AddWithValue("@MovieId", movie_Id);
                    cmd.Parameters.AddWithValue("@CustId", cust_Id);
                    cmd.Parameters.AddWithValue("@DateRented", rented_Date);

                    cmd.ExecuteNonQuery();

                }
                con.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int videoInsert(string title, DateTime release_Date, decimal cost, string genre, string plot)
        {

            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("insert into Movie(Title,ReleaseDate,RentalCost,Genre,Plot,Available)values(@Title,@ReleaseDate,@RentalCost,@Genre,@Plot,@Available)", con))
                {
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@ReleaseDate", release_Date);
                    cmd.Parameters.AddWithValue("@RentalCost", cost);
                    cmd.Parameters.AddWithValue("@Genre", genre);
                    cmd.Parameters.AddWithValue("@Plot", plot);
                    cmd.Parameters.AddWithValue("@Available", "Yes");
                    cmd.ExecuteNonQuery();

                }
                con.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int customerInsert(string first_Name, string last_name, string address, string mobile_No)
        {

            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("insert into Customer(FirstName,LastName,Address,Phone)values(@FirstName,@LastName,@Address,@Phone)", con))
                {
                    cmd.Parameters.AddWithValue("@FirstName", first_Name);
                    cmd.Parameters.AddWithValue("@LastName", last_name);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@Phone", mobile_No);

                    cmd.ExecuteNonQuery();

                }
                con.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public DataTable customerListBind()
        {
            DataTable dt = new DataTable();
            try
            {

                using (SqlCommand cmd = new SqlCommand("spGetAllCustomer", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {


                        da.Fill(dt);
                    }
                }
                return dt;
            }
            catch
            {
                return dt;
            }
        }
        public DataTable videoAllGet()
        {
            DataTable dt = new DataTable();
            try
            {

                using (SqlCommand cmd = new SqlCommand("select * from Movie", con))
                {

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                return dt;
            }
            catch
            {
                return dt;
            }
        }
        public int customerUpdate(string first_Name, string last_name, string address, string mobile_No, int cust_Id)
        {

            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("update Customer set FirstName=@FirstName,LastName=@LastName,Address=@Address,Phone=@Phone  where CustId=@CustId", con))
                {
                    cmd.Parameters.AddWithValue("@FirstName", first_Name);
                    cmd.Parameters.AddWithValue("@LastName", last_name);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@Phone", mobile_No);
                    cmd.Parameters.AddWithValue("@CustId", cust_Id);

                    cmd.ExecuteNonQuery();

                }
                con.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int customerDelete(int cust_Id)
        {

            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("delete from Customer where CustId=@CustId", con))
                {
                    cmd.Parameters.AddWithValue("@CustId", cust_Id);

                    cmd.ExecuteNonQuery();

                }
                con.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public DataTable viewRentedMovie()
        {
            DataTable dt = new DataTable();
            try
            {

                using (SqlCommand cmd = new SqlCommand("select * from ViewRentedMovies", con))
                {

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                return dt;
            }
            catch
            {
                return dt;
            }
        }
        public DataTable BindPopularVideo()
        {
            DataTable dt = new DataTable();
            try
            {

                using (SqlCommand cmd = new SqlCommand("select MovieId,Title,ReleaseDate,RentalCost,Genre,Count(*) as 'Total Rented' from ViewRentedMovies group by MovieId,Title,ReleaseDate,RentalCost,Genre order by 'Total Rented' desc", con))
                {

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                return dt;
            }
            catch
            {
                return dt;
            }
        }
        public int videoUpdate(string title, DateTime release_Date, decimal cost, string genre, string plot, int movie_Id)
        {

            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("update Movie set Title=@Title,ReleaseDate=@ReleaseDate,RentalCost=@RentalCost,Genre=@Genre,Plot=@Plot where MovieId=@MovieId", con))
                {
                    cmd.Parameters.AddWithValue("@MovieId", movie_Id);
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@ReleaseDate", release_Date);
                    cmd.Parameters.AddWithValue("@RentalCost", cost);
                    cmd.Parameters.AddWithValue("@Genre", genre);
                    cmd.Parameters.AddWithValue("@Plot", plot);


                    cmd.ExecuteNonQuery();

                }
                con.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int videoDelete(int movie_Id)
        {

            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("delete from Movie where MovieId=@MovieId", con))
                {
                    cmd.Parameters.AddWithValue("@MovieId", movie_Id);

                    cmd.ExecuteNonQuery();

                }
                con.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public DataTable videoAllAvailable()
        {
            DataTable dt = new DataTable();
            try
            {

                using (SqlCommand cmd = new SqlCommand("select * from Movie where Available='Yes'", con))
                {

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                return dt;
            }
            catch
            {
                return dt;
            }
        }
        public int ChangedStatus(int movie_Id, string status)
        {

            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("update Movie set Available=@Available where MovieId=@MovieId", con))
                {
                    cmd.Parameters.AddWithValue("@MovieId", movie_Id);
                    cmd.Parameters.AddWithValue("@Available", status);

                    cmd.ExecuteNonQuery();

                }
                con.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public DataTable viewrentedOutMovie()
        {
            DataTable dt = new DataTable();
            try
            {

                using (SqlCommand cmd = new SqlCommand("select * from ViewRentedMovies where DateReturned is Null", con))
                {

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                return dt;
            }
            catch
            {
                return dt;
            }
        }
        
        public DataTable MostComeCustomer()
        {
            DataTable dt = new DataTable();
            try
            {

                using (SqlCommand cmd = new SqlCommand("select CustId,FirstName,LastName,Address,Phone,Count(*) as 'Total Borrows' from ViewRentedMovies group by CustId,FirstName,LastName,Address,Phone order by 'Total Borrows' desc", con))
                {

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                return dt;
            }
            catch
            {
                return dt;
            }
        }
       
        public bool alreadyReturnVideo(int movie_Id)
        {

            try
            {
               
                using (SqlCommand cmd = new SqlCommand("select * from Movie where Available='No' and MovieId=" + movie_Id + "", con))
                {
                    SqlDataReader rdr;
                    rdr = cmd.ExecuteReader();
                    if (rdr.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                   
                }
               

            }
            catch
            {
                
                return true;
            }
        }
    }
}
