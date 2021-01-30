using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Magazin.BLL;

namespace Magazin.DAL
{
    class ClientDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        #region Select Data from Database
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM CLIENT";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion
        #region Insert Data in Database
        public bool Insert(ClientBLL u)
        {
            bool isSucces = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                String sql = "INSERT INTO CLIENT (nume, prenume, contact) VALUES (@nume, @prenume, @contact)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@nume", u.nume);
                cmd.Parameters.AddWithValue("@prenume", u.prenume);
                cmd.Parameters.AddWithValue("@contact", u.contact);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows>0)//Query a reusit
                {
                    isSucces = true;
                }
                else
                {
                    isSucces = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSucces;
        }
        #endregion
        #region Update Data in Database
        public bool Update(ClientBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE CLIENT SET nume=@nume, prenume=@prenume, contact=@contact WHERE client_id=@client_id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@client_id", u.client_id);
                cmd.Parameters.AddWithValue("@nume", u.nume);
                cmd.Parameters.AddWithValue("@prenume", u.prenume);
                cmd.Parameters.AddWithValue("@contact", u.contact);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)//Querry a functionat
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
        #endregion
        #region Delete Data from Database
        public bool Delete(ClientBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM CLIENT WHERE client_id=@client_id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@client_id", u.client_id);
                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)//Querry a functionat
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
        #endregion
        #region Search user in Database using Keywords
        public DataTable Search(string keywords)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM CLIENT WHERE client_id like '% "+keywords+"%' OR nume LIKE '%"+keywords+"%' OR prenume LIKE '%"+keywords+"%' OR prenume LIKE '%"+keywords+"%' OR contact LIKE '%"+keywords+"%'" ;
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion
    }
}
