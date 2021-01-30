using Magazin.BLL;
using Magazin.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazin.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        LoginBLL l = new LoginBLL();
        LoginDAL dal = new LoginDAL();
         public static string loggedIn;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            l.client_id = txtUsername.Text.Trim();
            bool succes = dal.loginCheck(l);
            if(succes == true)
            {
                MessageBox.Show("Login Succesful");
                loggedIn = l.client_id;
                if (Convert.ToBoolean(string.Compare(l.client_id, "6")))
                {
                    frmUserDashboard user = new frmUserDashboard();
                    user.Show();
                    this.Hide();
                }
                else
                { 
                    frmAdminDashboard admin = new frmAdminDashboard();
                    admin.Show();
                    this.Hide();
                }
                    
                
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }
    }
}
