using Magazin.BLL;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Magazin.DAL
{
    class FurnizorDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Select Method

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM FURNIZOR";

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
        #region Insert Method

        public bool Insert(FurnizorBLL f)
        {
            bool isSucces = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO FURNIZOR (nume_furnizor, tara, oras, furnizor_id) VALUES (@nume_furnizor, @tara, @oras, @furnizor_id)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@furnizor_id", f.furnizor_id);
                cmd.Parameters.AddWithValue("@nume_furnizor", f.nume_furnizor);
                cmd.Parameters.AddWithValue("@tara", f.tara);
                cmd.Parameters.AddWithValue("@oras", f.oras);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSucces = true;

                }
                else
                {
                    isSucces = false;
                }

            }
            catch (Exception ex)
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
        #region Update Method
        public bool Update(FurnizorBLL f)
        {
            bool isSucces = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE FURNIZOR SET nume_furnizor=@nume_furnizor, tara=@tara, oras=@oras WHERE furnizor_id=@furnizor_id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@furnizor_id", f.furnizor_id);
                cmd.Parameters.AddWithValue("@nume_furnizor", f.nume_furnizor);
                cmd.Parameters.AddWithValue("@tara", f.tara);
                cmd.Parameters.AddWithValue("@oras", f.oras);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSucces = true;
                }
                else
                {
                    isSucces = false;
                }

            }
            catch (Exception ex)
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
        #region Delete Method

        public bool Delete(FurnizorBLL f)
        {
            bool isSucces = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "DELETE FROM FURNIZOR WHERE furnizor_id=@furnizor_id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@furnizor_id", f.furnizor_id);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSucces = true;

                }
                else
                {
                    isSucces = false;
                }

            }
            catch (Exception ex)
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
        #region Search Method
        public DataTable Search(string keywords)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM FURNIZOR WHERE nume_furnizor like '% " + keywords + "%' OR furnizor_id like '% " + keywords + "%' OR oras like '% " + keywords + "%' OR tara LIKE '%" + keywords + "%'";
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
