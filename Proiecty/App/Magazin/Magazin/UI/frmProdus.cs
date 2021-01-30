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
    public partial class frmProdus : Form
    {
        public frmProdus()
        {
            InitializeComponent();
        }

        private void lblCod_Click(object sender, EventArgs e)
        {

        }
        CategorieDAL cdal = new CategorieDAL();
        FurnizorDAL fdal = new FurnizorDAL();
        ProdusDAL dal = new ProdusDAL();
        ProdusBLL p = new ProdusBLL();
        private void frmProdus_Load(object sender, EventArgs e)
        {
                DataTable categoriedt = cdal.Select();
                cmbCategorie.DataSource = categoriedt;
                cmbCategorie.DisplayMember = "categorie_id";
                cmbCategorie.ValueMember = "categorie_id";
                DataTable furnizordt = fdal.Select();
                cmbFurnizor.DataSource = furnizordt;
                cmbFurnizor.DisplayMember = "furnizor_id";
                cmbFurnizor.ValueMember = "furnizor_id";
                DataTable dt = dal.Select();
                dgvProdus.DataSource = dt;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            txtCod.Text = "";
            txtDescriere.Text = "";
            txtNume.Text = "";
            txtPret.Text = "";
            txtSearch.Text = "";
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;

            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dgvProdus.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgvProdus.DataSource = dt;
            }
        }

        private void dgvProdus_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtCod.Text = dgvProdus.Rows[RowIndex].Cells[0].Value.ToString();
            cmbCategorie.Text = dgvProdus.Rows[RowIndex].Cells[1].Value.ToString();
            cmbFurnizor.Text = dgvProdus.Rows[RowIndex].Cells[2].Value.ToString();
            txtNume.Text = dgvProdus.Rows[RowIndex].Cells[3].Value.ToString();
            txtPret.Text = dgvProdus.Rows[RowIndex].Cells[4].Value.ToString();
            txtDescriere.Text = dgvProdus.Rows[RowIndex].Cells[5].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            p.cod_produs = Convert.ToInt32(txtCod.Text);
            p.nume = txtNume.Text;
            p.descriere = txtDescriere.Text;
            p.pret = Convert.ToDecimal(txtPret.Text);
            p.furnizor =Convert.ToInt32( cmbFurnizor.Text);
            p.categorie = Convert.ToInt32(cmbCategorie.Text);


            bool succes = dal.Insert(p);

            if (succes)
            {
                MessageBox.Show("Produsul a fost creat cu succes.");
                Clear();
                DataTable dt = dal.Select();
                dgvProdus.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Nu s-a putut crea noul produs.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            p.cod_produs = int.Parse(txtCod.Text);
            p.nume = txtNume.Text;
            p.descriere = txtDescriere.Text;
            p.furnizor = Convert.ToInt32(cmbFurnizor.Text);
            p.categorie = Convert.ToInt32(cmbCategorie.Text);
            p.pret = Convert.ToDecimal(txtPret.Text);

            bool succes = dal.Update(p);
            if (succes)
            {
                MessageBox.Show("Produs actualizat cu succes.");
                Clear();
                DataTable dt = dal.Select();
                dgvProdus.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Produsul nu a fost actualizat.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            p.cod_produs = int.Parse(txtCod.Text);

            bool succes = dal.Delete(p);

            if (succes)
            {
                MessageBox.Show("Produs sters cu succes.");
                Clear();
                DataTable dt = dal.Select();
                dgvProdus.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Produsul nu a fost sters.");
            }
        }
    }
}
