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
    class LoginDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        public bool loginCheck(LoginBLL l)
        {
            bool isSucces = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "SELECT * FROM CLIENT WHERE client_id=@client_id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@client_id", l.client_id);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
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
    }
}
