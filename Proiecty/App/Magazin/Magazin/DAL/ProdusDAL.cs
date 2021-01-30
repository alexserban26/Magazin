using Magazin.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazin.DAL
{
    class ProdusDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Select Method

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM PRODUS";

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

        public bool Insert(ProdusBLL p)
        {
            bool isSucces = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO PRODUS (cod_produs, categorie_id, furnizor_id, nume_produs, pret, descriere) VALUES (@cod_produs, @categorie_id, @furnizor_id, @nume_produs, @pret, @descriere)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@cod_produs", p.cod_produs);
                cmd.Parameters.AddWithValue("@categorie_id", p.categorie);
                cmd.Parameters.AddWithValue("@descriere", p.descriere);
                cmd.Parameters.AddWithValue("@furnizor_id", p.furnizor);
                cmd.Parameters.AddWithValue("@nume_produs", p.nume);
                cmd.Parameters.AddWithValue("@pret", p.pret);

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
        public bool Update(ProdusBLL p)
        {
            bool isSucces = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE PRODUS SET nume_produs=@nume_produs, pret=@pret, descriere=@descriere WHERE cod_produs=@cod_produs";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@cod_produs", p.cod_produs);
                cmd.Parameters.AddWithValue("@descriere", p.descriere);
                cmd.Parameters.AddWithValue("@nume_produs", p.nume);
                cmd.Parameters.AddWithValue("@pret", p.pret);

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

        public bool Delete(ProdusBLL p)
        {
            bool isSucces = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "DELETE FROM PRODUS WHERE cod_produs=@cod_produs";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@cod_produs", p.cod_produs);

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
                String sql = "SELECT * FROM PRODUS WHERE pret like '% " + keywords + "%' OR furnizor_id like '% " + keywords + "%' OR categorie_id like '% " + keywords + "%' OR nume_produs LIKE '%" + keywords + "%' OR descriere LIKE '%" + keywords + "%'";
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
