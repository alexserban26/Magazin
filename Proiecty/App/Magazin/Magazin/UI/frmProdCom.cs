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
    public partial class frmProdCom : Form
    {
        public frmProdCom()
        {
            InitializeComponent();
        }
        ProdComBLL p = new ProdComBLL();
        ProdComDAL dal = new ProdComDAL();
        public void Clear()
        {
            txtCantitate.Text = "";
            txtCodProd.Text = "";
            txtId.Text = "";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPrenume_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProdCom_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvProdCom.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            p.Id_comanda = Convert.ToInt32(txtId.Text);
            p.cod_produs = int.Parse(txtCodProd.Text);
            p.cantitate = int.Parse(txtCantitate.Text);
            bool succes = dal.Insert(p);

            if (succes)
            {
                MessageBox.Show("ProdCom a fost creat cu succes.");
                Clear();
                DataTable dt = dal.Select();
                dgvProdCom.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Nu s-a putut crea noul ProdCom.");
            }
        }

        private void dgvProdCom_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtId.Text = dgvProdCom.Rows[RowIndex].Cells[0].Value.ToString();
            txtCodProd.Text = dgvProdCom.Rows[RowIndex].Cells[1].Value.ToString();
            txtCantitate.Text = dgvProdCom.Rows[RowIndex].Cells[2].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            p.Id_comanda = Convert.ToInt32(txtId.Text);
            p.cod_produs = int.Parse(txtCodProd.Text);
            p.cantitate = int.Parse(txtCantitate.Text);

            bool succes = dal.Update(p);
            if (succes)
            {
                MessageBox.Show("ProdCom actualizat cu succes.");
                Clear();
                DataTable dt = dal.Select();
                dgvProdCom.DataSource = dt;

            }
            else
            {
                MessageBox.Show("ProdCom nu a fost actualizat.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            p.Id_comanda = Convert.ToInt32(txtId.Text);
            p.cod_produs = int.Parse(txtCodProd.Text);
            bool succes = dal.Delete(p);

            if (succes)
            {
                MessageBox.Show("ProdCom sters cu succes.");
                Clear();
                DataTable dt = dal.Select();
                dgvProdCom.DataSource = dt;

            }
            else
            {
                MessageBox.Show("ProdCom nu a fost sters.");
            }
        }
    }
}
