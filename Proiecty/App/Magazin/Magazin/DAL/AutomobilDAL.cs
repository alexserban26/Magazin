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
    class AutomobilDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Select Method

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM AUTOMOBIL";

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

        public bool Insert(AutomobilBLL a)
        {
            bool isSucces = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO AUTOMOBIL (automobil_id, producator, model, an_incepere_fabricatie, an_incetare_fabricatie, tip) VALUES (@automobil_id, @producator, @model, @an_incepere_fabricatie, @an_incetare_fabricatie, @tip)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@automobil_id", a.Id);
                cmd.Parameters.AddWithValue("@producator", a.Producator);
                cmd.Parameters.AddWithValue("@model", a.Model);
                cmd.Parameters.AddWithValue("@an_incepere_fabricatie", a.Incepere);
                cmd.Parameters.AddWithValue("@an_incetare_fabricatie", a.Incetare);
                cmd.Parameters.AddWithValue("@tip", a.Tip);

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
        public bool Update(AutomobilBLL a)
        {
            bool isSucces = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE AUTOMOBIL SET producator=@producator, model=@model, an_incepere_fabricatie=@an_incepere_fabricatie, an_incetare_fabricatie=an_incetare_fabricatie, tip=@tip WHERE automobil_id=@automobil_id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@automobil_id", a.Id);
                cmd.Parameters.AddWithValue("@producator", a.Producator);
                cmd.Parameters.AddWithValue("@model", a.Model);
                cmd.Parameters.AddWithValue("@an_incepere_fabricatie", a.Incepere);
                cmd.Parameters.AddWithValue("@an_incetare_fabricatie", a.Incetare);
                cmd.Parameters.AddWithValue("@tip", a.Tip);

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

        public bool Delete(AutomobilBLL a)
        {
            bool isSucces = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "DELETE FROM AUTOMOBIL WHERE automobil_id=@automobil_id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@automobil_id", a.Id);

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
                String sql = "SELECT * FROM AUTOMOBIL WHERE producator like '% " + keywords + "%' OR model like '% " + keywords + "%' OR tip like '% " + keywords + "%' OR an_incepere_fabricatie LIKE '%" + keywords + "%' OR an_incetare_fabricatie LIKE '%" + keywords + "%'";
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
