using Magazin.BLL;
using Magazin.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazin.UI
{
    public partial class frmComanda : Form
    {
        public frmComanda()
        {
            InitializeComponent();
        }
        ComandaDAL dal = new ComandaDAL();
        ComandaBLL c = new ComandaBLL();
        public void Clear()
        {
            txtAdresaID.Text = "";
            txtComandaID.Text = "";
            txtNume.Text = "";
            txtPrenume.Text = "";
            txtSearch.Text = "";
            txtDataComanda.Text = "";
            txtDataExpediere.Text = "";
            txtStare.Text = "";
            txtSuma.Text = "";
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmComanda_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvComanda.DataSource = dt;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;

            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dgvComanda.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgvComanda.DataSource = dt;
            }
        }

        private void dgvComanda_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtAdresaID.Text = dgvComanda.Rows[RowIndex].Cells[1].Value.ToString(); 
            txtComandaID.Text = dgvComanda.Rows[RowIndex].Cells[0].Value.ToString();
            txtNume.Text = dgvComanda.Rows[RowIndex].Cells[2].Value.ToString();
            txtPrenume.Text = dgvComanda.Rows[RowIndex].Cells[3].Value.ToString();
            txtDataComanda.Text = dgvComanda.Rows[RowIndex].Cells[4].Value.ToString();
            txtDataExpediere.Text = dgvComanda.Rows[RowIndex].Cells[5].Value.ToString();
            txtStare.Text = dgvComanda.Rows[RowIndex].Cells[6].Value.ToString();
            txtSuma.Text = dgvComanda.Rows[RowIndex].Cells[7].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            c.adresa_id=Convert.ToInt32(txtAdresaID.Text);
            c.data_comanda = Convert.ToDateTime(txtDataComanda.Text);
            c.data_expediere=Convert.ToDateTime(txtDataExpediere.Text);
            c.stare=txtStare.Text;
            bool succes = dal.Insert(c);

            if (succes)
            {
                MessageBox.Show("Comanda a fost creata cu succes.");
                Clear();
                DataTable dt = dal.Select();
                dgvComanda.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Nu s-a putut crea noua comanda.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            c.adresa_id = Convert.ToInt32(txtAdresaID.Text);
            c.comanda_id = Convert.ToInt32(txtComandaID.Text);
            c.data_comanda = Convert.ToDateTime(txtDataComanda.Text);
            c.data_expediere = Convert.ToDateTime(txtDataExpediere.Text);
            c.stare = txtStare.Text;
            bool succes = dal.Update(c);

            if (succes)
            {
                MessageBox.Show("Comanda a fost actualizata cu succes.");
                Clear();
                DataTable dt = dal.Select();
                dgvComanda.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Nu s-a putut actualiza comanda.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            c.comanda_id = Convert.ToInt32(txtComandaID.Text);
            bool succes = dal.Delete(c);

            if (succes)
            {
                MessageBox.Show("Comanda stearsa cu succes.");
                Clear();
                DataTable dt = dal.Select();
                dgvComanda.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Comanda nu a fost stearsa.");
            }
        }

        private void btnComenziMari_Click(object sender, EventArgs e)
        {
            DataTable dt = dal.Select_having();
            dgvComanda.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvComanda.DataSource = dt;
        }
    }
}
