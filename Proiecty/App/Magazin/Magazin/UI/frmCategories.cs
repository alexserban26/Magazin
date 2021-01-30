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
    public partial class frmCategories : Form
    {
        public frmCategories()
        {
            InitializeComponent();
        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvCategorie.DataSource = dt;
        }

        private void lblCod_Click(object sender, EventArgs e)
        {

        }

        private void lblPrenume_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        CategorieBLL c = new CategorieBLL();
        CategorieDAL dal = new CategorieDAL();
        
        private void btnAdd_Click(object sender, EventArgs e)
        {   
            c.Id = Convert.ToInt32(txtId.Text);
            c.Nume = txtNume.Text;
            c.Descriere = txtDescriere.Text;
            bool succes = dal.Insert(c);

            if (succes)
            {
                MessageBox.Show("Categoria a fost creata cu succes.");
                Clear();
                DataTable dt = dal.Select();
                dgvCategorie.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Nu s-a putut crea noua categorie.");
            }
        }

        public void Clear()
        {
            txtId.Text = "";
            txtNume.Text = "";
            txtDescriere.Text = "";
            txtSearch.Text = "";
        }

        private void dgvCategorie_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtId.Text = dgvCategorie.Rows[RowIndex].Cells[0].Value.ToString();
            txtNume.Text = dgvCategorie.Rows[RowIndex].Cells[1].Value.ToString();
            txtDescriere.Text = dgvCategorie.Rows[RowIndex].Cells[2].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            c.Id = int.Parse(txtId.Text);
            c.Nume = txtNume.Text;
            c.Descriere = txtDescriere.Text;

            bool succes=dal.Update(c);
            if (succes)
            {
                MessageBox.Show("Categorie actualizata cu succes.");
                Clear();
                DataTable dt = dal.Select();
                dgvCategorie.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Categoria nu a fost actualizata");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            c.Id = int.Parse(txtId.Text);

            bool succes = dal.Delete(c);

            if(succes)
            {
                MessageBox.Show("Categorie stearsa cu succes.");
                Clear();
                DataTable dt = dal.Select();
                dgvCategorie.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Categoria nu a fost stearsa.");
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;

            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dgvCategorie.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgvCategorie.DataSource = dt;
            }
        }

        private void lblOrder_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
