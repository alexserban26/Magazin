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
    class AutoCompDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Select Method

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM AUTOMOBIL_COMPATIBIL";

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

        public bool Insert(AutoCompBLL a)
        {
            bool isSucces = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO AUTOMOBIL_COMPATIBIL (automobil_id, cod_produs, cod_motor, producator, model, an_fabricatie) VALUES (@automobil_id, @cod_produs, @cod_motor, @producator, @model, @an_fabricatie)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@automobil_id", a.Id);
                cmd.Parameters.AddWithValue("@cod_produs", a.Cod_produs);
                cmd.Parameters.AddWithValue("@cod_motor", a.Cod_motor);
                cmd.Parameters.AddWithValue("@producator", a.Producator);
                cmd.Parameters.AddWithValue("@model", a.Model);
                cmd.Parameters.AddWithValue("@an_fabricatie", a.An_fabricatie);

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
        public bool Update(AutoCompBLL a)
        {
            bool isSucces = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE AUTOMOBIL_COMPATIBIL SET cod_motor=@cod_motor, producator=@producator, model=@model, an_fabricatie=@an_fabricatie WHERE cod_produs=@cod_produs AND automobil_id=@automobil_id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@automobil_id", a.Id);
                cmd.Parameters.AddWithValue("@cod_produs", a.Cod_produs);
                cmd.Parameters.AddWithValue("@cod_motor", a.Cod_motor);
                cmd.Parameters.AddWithValue("@producator", a.Producator);
                cmd.Parameters.AddWithValue("@model", a.Model);
                cmd.Parameters.AddWithValue("@an_fabricatie", a.An_fabricatie);

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

        public bool Delete(AutoCompBLL a)
        {
            bool isSucces = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "DELETE FROM AUTOMOBIL_COMPATIBIL WHERE cod_produs=@cod_produs AND automobil_id=@automobil_id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@automobil_id", a.Id);
                cmd.Parameters.AddWithValue("@cod_produs", a.Cod_produs);

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
                String sql = "SELECT * FROM AUTOMOBIL_COMPATIBIL WHERE automobil_id like '% " + keywords + "%' OR cod_produs like '% " + keywords + "%' OR model like '% " + keywords + "%' OR producator LIKE '%" + keywords + "%' OR an_fabricatie LIKE '%" + keywords + "%' OR cod_motor LIKE '%" + keywords + "%'";
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
