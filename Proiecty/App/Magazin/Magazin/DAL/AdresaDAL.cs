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
    class AdresaDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        #region Select Method

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM ADRESA ad JOIN CLIENT cl ON cl.client_id=ad.client_id";

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

        public bool Insert(AdresaBLL a)
        {
            bool isSucces = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO ADRESA (client_id, oras, strada, numar, bloc, scara, etaj, apartament) VALUES ( @client_id, @oras, @strada, @numar, @bloc, @scara, @etaj, @apartament)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@client_id", a.Id_client);
                cmd.Parameters.AddWithValue("@oras", a.Oras);
                cmd.Parameters.AddWithValue("@strada", a.Strada);
                cmd.Parameters.AddWithValue("@numar", a.Numar);
                cmd.Parameters.AddWithValue("@bloc", a.Bloc);
                cmd.Parameters.AddWithValue("@scara", a.Scara);
                cmd.Parameters.AddWithValue("@etaj", a.Etaj);
                cmd.Parameters.AddWithValue("@apartament", a.Apartament);


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
        public bool Update(AdresaBLL a)
        {
            bool isSucces = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE ADRESA SET client_id=@client_id, oras=@oras, strada=@strada, numar=@numar, bloc=@bloc, scara=@scara, etaj=@etaj, apartament=@apartament WHERE adresa_id=@adresa_id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@adresa_id", a.Id_adresa);
                cmd.Parameters.AddWithValue("@client_id", a.Id_client);
                cmd.Parameters.AddWithValue("@oras", a.Oras);
                cmd.Parameters.AddWithValue("@strada", a.Strada);
                cmd.Parameters.AddWithValue("@numar", a.Numar);
                cmd.Parameters.AddWithValue("@bloc", a.Bloc);
                cmd.Parameters.AddWithValue("@scara", a.Scara);
                cmd.Parameters.AddWithValue("@etaj", a.Etaj);
                cmd.Parameters.AddWithValue("@apartament", a.Apartament);

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

        public bool Delete(AdresaBLL a)
        {
            bool isSucces = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM ADRESA WHERE adresa_id=@adresa_id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@adresa_id", a.Id_adresa);
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
        #region Search in Database using Keywords
        public DataTable Search(string keywords)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM ADRESA WHERE oras like '% " + keywords + "%' OR strada LIKE '%" + keywords + "%' OR bloc LIKE '%" + keywords + "%'";
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
