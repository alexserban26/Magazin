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
    public partial class frmFurnizor : Form
    {
        public frmFurnizor()
        {
            InitializeComponent();
        }
        FurnizorBLL f = new FurnizorBLL();
        FurnizorDAL dal = new FurnizorDAL();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPrenume_Click(object sender, EventArgs e)
        {

        }

        private void lblNume_Click(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            txtId.Text = "";
            txtNume.Text = "";
            txtTara.Text = "";
            txtOras.Text = "";
            txtSearch.Text = "";
        }
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvFurnizor_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtId.Text = dgvFurnizor.Rows[RowIndex].Cells[0].Value.ToString();
            txtNume.Text = dgvFurnizor.Rows[RowIndex].Cells[1].Value.ToString();
            txtTara.Text = dgvFurnizor.Rows[RowIndex].Cells[2].Value.ToString();
            txtOras.Text = dgvFurnizor.Rows[RowIndex].Cells[3].Value.ToString();
        }
        
        private void frmFurnizor_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvFurnizor.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            f.furnizor_id = int.Parse(txtId.Text);
            f.nume_furnizor = txtNume.Text;
            f.tara = txtTara.Text;
            f.oras = txtOras.Text;
            bool succes = dal.Insert(f);

            if (succes)
            {
                MessageBox.Show("Furnizorul a fost creat cu succes.");
                Clear();
                DataTable dt = dal.Select();
                dgvFurnizor.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Nu s-a putut crea noul furnizor.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            f.furnizor_id = int.Parse(txtId.Text);
            f.nume_furnizor = txtNume.Text;
            f.tara = txtTara.Text;
            f.oras = txtOras.Text;

            bool succes = dal.Update(f);
            if (succes)
            {
                MessageBox.Show("Furnizor actualizat cu succes.");
                Clear();
                DataTable dt = dal.Select();
                dgvFurnizor.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Furnizorul nu a fost actualizat.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            f.furnizor_id = Convert.ToInt32(txtId.Text);

            bool succes = dal.Delete(f);

            if (succes)
            {
                MessageBox.Show("Furnizor sters cu succes.");
                Clear();
                DataTable dt = dal.Select();
                dgvFurnizor.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Furnizorul nu a fost sters.");
            }
        }
    }
}
