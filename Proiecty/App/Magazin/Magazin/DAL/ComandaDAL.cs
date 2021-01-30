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
    class ComandaDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        #region Select Method

        public DataTable Select()

        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT PC.comanda_id, C.adresa_id, CL.nume, CL.prenume, C.data_comanda, C.data_expediere, C.stare, sum(P.pret * cantitate) 'SUMA COMANDA' FROM PRODUSE_COMANDATE PC JOIN PRODUS P ON P.cod_produs = PC.cod_produs JOIN COMANDA C ON PC.comanda_id = C.comanda_id JOIN ADRESA A ON A.adresa_id = C.adresa_id JOIN CLIENT CL ON A.client_id = CL.client_id GROUP BY PC.comanda_id, C.adresa_id, CL.nume,Cl.prenume,C.data_comanda,C.data_expediere,C.stare";

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

        public bool Insert(ComandaBLL c)
        {
            bool isSucces = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO COMANDA (adresa_id, data_comanda, data_expediere, stare) VALUES ( @adresa_id, @data_comanda, @data_expediere, @stare)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@adresa_id", c.adresa_id);
                cmd.Parameters.AddWithValue("@data_comanda", c.data_comanda);
                cmd.Parameters.AddWithValue("@data_expediere", c.data_expediere);
                cmd.Parameters.AddWithValue("@stare", c.stare);

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
        public bool Update(ComandaBLL c)
        {
            bool isSucces = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE COMANDA SET adresa_id=@adresa_id, data_comanda=@data_comanda, data_expediere=@data_expediere, stare=@stare WHERE comanda_id=@comanda_id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@comanda_id", c.comanda_id);
                cmd.Parameters.AddWithValue("@adresa_id", c.adresa_id);
                cmd.Parameters.AddWithValue("@data_comanda", c.data_comanda);
                cmd.Parameters.AddWithValue("@data_expediere", c.data_expediere);
                cmd.Parameters.AddWithValue("@stare", c.stare);

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

        public bool Delete(ComandaBLL c)
        {
            bool isSucces = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM COMANDA WHERE comanda_id=@comanda_id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@comanda_id", c.comanda_id);
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
                String sql = "SELECT * FROM COMANDA WHERE adresa_id like '% " + keywords + "%' OR data_comanda LIKE '%" + keywords + "%' OR data_expediere LIKE '%" + keywords + "%'";
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
        #region Select+having Method
        public DataTable Select_having()

        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT PC.comanda_id, C.adresa_id, CL.nume, CL.prenume, C.data_comanda, C.data_expediere, C.stare, sum(P.pret * cantitate) 'SUMA COMANDA' FROM PRODUSE_COMANDATE PC JOIN PRODUS P ON P.cod_produs = PC.cod_produs JOIN COMANDA C ON PC.comanda_id = C.comanda_id JOIN ADRESA A ON A.adresa_id = C.adresa_id JOIN CLIENT CL ON A.client_id = CL.client_id GROUP BY PC.comanda_id, C.adresa_id, CL.nume,Cl.prenume,C.data_comanda,C.data_expediere,C.stare HAVING SUM(P.pret*cantitate)>100";

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
