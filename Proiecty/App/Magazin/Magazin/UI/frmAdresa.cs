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
    public partial class frmAdresa : Form
    {
        public frmAdresa()
        {
            InitializeComponent();
        }
        AdresaDAL dal = new AdresaDAL();
        AdresaBLL a = new AdresaBLL();
        public void Clear()
        {
            txtId.Text = "";
            txtIDClient.Text = "";
            txtNume.Text = "";
            txtPrenume.Text = "";
            txtSearch.Text = "";
            txtOras.Text = "";
            txtStrada.Text = "";
            txtNumar.Text = "";
            txtScara.Text = "";
            txtBloc.Text = "";
            txtEtaj.Text = "";
            txtApartament.Text = "";
        }
        private void frmAdresa_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvAdresa.DataSource = dt;
        }

        private void lblCod_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtNumar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;

            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dgvAdresa.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgvAdresa.DataSource = dt;
            }
        }

        private void dgvAdresa_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtId.Text = dgvAdresa.Rows[RowIndex].Cells[0].Value.ToString(); 
            txtIDClient.Text = dgvAdresa.Rows[RowIndex].Cells[1].Value.ToString();
            txtNume.Text = dgvAdresa.Rows[RowIndex].Cells[10].Value.ToString();
            txtPrenume.Text = dgvAdresa.Rows[RowIndex].Cells[11].Value.ToString();
            txtOras.Text = dgvAdresa.Rows[RowIndex].Cells[2].Value.ToString();
            txtStrada.Text = dgvAdresa.Rows[RowIndex].Cells[3].Value.ToString();
            txtNumar.Text = dgvAdresa.Rows[RowIndex].Cells[4].Value.ToString();
            txtBloc.Text = dgvAdresa.Rows[RowIndex].Cells[5].Value.ToString();
            txtEtaj.Text = dgvAdresa.Rows[RowIndex].Cells[6].Value.ToString();
            txtApartament.Text = dgvAdresa.Rows[RowIndex].Cells[7].Value.ToString();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        { 
            a.Id_client = Convert.ToInt32(txtIDClient.Text);
            a.Oras = txtOras.Text;
            a.Strada = txtStrada.Text;
            a.Numar =Convert.ToInt32( txtNumar.Text);
            a.Bloc = txtBloc.Text;
            a.Scara = txtScara.Text;
            a.Etaj = int.Parse(txtEtaj.Text);
            a.Apartament = int.Parse(txtApartament.Text);


            bool succes = dal.Insert(a);

            if (succes)
            {
                MessageBox.Show("Adresa a fost creata cu succes.");
                Clear();
                DataTable dt = dal.Select();
                dgvAdresa.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Nu s-a putut crea noua adresa.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            a.Id_adresa = Convert.ToInt32(txtId.Text);
            a.Id_client = Convert.ToInt32(txtIDClient.Text);
            a.Oras = txtOras.Text;
            a.Strada = txtStrada.Text;
            a.Numar = Convert.ToInt32(txtNumar.Text);
            a.Bloc = txtBloc.Text;
            a.Scara = txtScara.Text;
            a.Etaj = Convert.ToInt32(txtEtaj.Text);
            a.Apartament = Convert.ToInt32(txtApartament.Text);

            bool succes = dal.Update(a);

            if (succes)
            {
                MessageBox.Show("Adresa a fost actualizata cu succes.");
                Clear();
                DataTable dt = dal.Select();
                dgvAdresa.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Nu s-a putut actualiza adresa.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            a.Id_adresa = Convert.ToInt32(txtId.Text);
            bool succes = dal.Delete(a);

            if (succes)
            {
                MessageBox.Show("Adresa stearsa cu succes.");
                Clear();
                DataTable dt = dal.Select();
                dgvAdresa.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Adresa nu a fost stearsa.");
            }
        }
    }
}
