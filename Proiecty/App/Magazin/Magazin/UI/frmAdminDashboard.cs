using Magazin.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazin
{
    public partial class frmAdminDashboard : Form
    {
        public frmAdminDashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblAppFName_Click(object sender, EventArgs e)
        {

        }

        private void lblLogedInUser_Load(object sender, EventArgs e)
        {
            lblLogedInUser.Text = frmLogin.loggedIn;
        }

        private void utilizatoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers user = new frmUsers();
            user.Show();
        }

        private void frmAdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menuStripTop_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void utilizatoriToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmUsers user = new frmUsers();
            user.Show();
        }

        private void categoriiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategories category = new frmCategories();
            category.Show();
        }

        private void lblLName_Click(object sender, EventArgs e)
        {

        }

        private void produseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProdus produs = new frmProdus();
                produs.Show();
        }

        private void furnizoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFurnizor furnizor = new frmFurnizor();
            furnizor.Show();
        }

        private void automobileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutomobil automobil = new frmAutomobil();
            automobil.Show();
        }

        private void automobileCompatibileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutoComp autocomp = new frmAutoComp();
            autocomp.Show();
        }

        private void adreseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdresa adresa = new frmAdresa();
            adresa.Show();
        }

        private void produseComandateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProdCom prodcom = new frmProdCom();
            prodcom.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comenziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmComanda comanda = new frmComanda();
            comanda.Show();
        }
    }
}
