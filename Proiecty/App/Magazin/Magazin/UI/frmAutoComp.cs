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
    public partial class frmAutoComp : Form
    {
        public frmAutoComp()
        {
            InitializeComponent();
        }
        AutoCompDAL dal = new AutoCompDAL();
        AutoCompBLL a = new AutoCompBLL();

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Clear()
        {
            txtId.Text = "";
            txtCodProd.Text = "";
            txtCodMotor.Text = "";
            txtAn.Text = "";
            txtSearch.Text = "";
            txtModel.Text = "";
            txtProducator.Text = "";
            
        }
        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAutoComp_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvAutoComp.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;

            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dgvAutoComp.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgvAutoComp.DataSource = dt;
            }
        }

        private void dgvAutoComp_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtId.Text = dgvAutoComp.Rows[RowIndex].Cells[0].Value.ToString();
            txtCodProd.Text = dgvAutoComp.Rows[RowIndex].Cells[1].Value.ToString();
            txtCodMotor.Text = dgvAutoComp.Rows[RowIndex].Cells[2].Value.ToString();
            txtProducator.Text = dgvAutoComp.Rows[RowIndex].Cells[3].Value.ToString();
            txtModel.Text = dgvAutoComp.Rows[RowIndex].Cells[4].Value.ToString();
            txtAn.Text = dgvAutoComp.Rows[RowIndex].Cells[5].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            a.Id = Convert.ToInt32(txtId.Text);
            a.Cod_produs = Convert.ToInt32(txtCodProd.Text);
            a.Cod_motor = txtCodMotor.Text;
            a.Producator = txtProducator.Text;
            a.Model = txtModel.Text;
            a.An_fabricatie = Convert.ToInt32(txtAn.Text);


            bool succes = dal.Insert(a);

            if (succes)
            {
                MessageBox.Show("AutoComp a fost creat cu succes.");
                Clear();
                DataTable dt = dal.Select();
                dgvAutoComp.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Nu s-a putut crea noul AutoComp.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            a.Id = Convert.ToInt32(txtId.Text);
            a.Cod_produs = Convert.ToInt32(txtCodProd.Text);
            a.Cod_motor = txtCodMotor.Text;
            a.Producator = txtProducator.Text;
            a.Model = txtModel.Text;
            a.An_fabricatie = int.Parse(txtAn.Text);


            bool succes = dal.Update(a);

            if (succes)
            {
                MessageBox.Show("AutoComp a fost actualizat cu succes.");
                Clear();
                DataTable dt = dal.Select();
                dgvAutoComp.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Nu s-a putut actualiza  AutoComp.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            a.Id = Convert.ToInt32(txtId.Text);
            a.Cod_produs = Convert.ToInt32(txtCodProd.Text);
            bool succes = dal.Delete(a);

            if (succes)
            {
                MessageBox.Show("AutoComp sters cu succes.");
                Clear();
                DataTable dt = dal.Select();
                dgvAutoComp.DataSource = dt;

            }
            else
            {
                MessageBox.Show("AutoComp nu a fost sters.");
            }
        }
    }
}
