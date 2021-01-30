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
    public partial class frmAutomobil : Form
    {
        AutomobilDAL dal = new AutomobilDAL();
        AutomobilBLL a = new AutomobilBLL();
        public frmAutomobil()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            txtId.Text = "";
            txtTip.Text = "";
            txtAnincepere.Text = "";
            txtAnincetare.Text = "";
            txtSearch.Text = "";
            txtModel.Text = "";
            txtProducator.Text = "";
            
        }
        private void frmAutomobil_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvAutomobil.DataSource = dt;
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
                dgvAutomobil.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgvAutomobil.DataSource = dt;
            }
        }

        private void dgvAutomobil_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtId.Text = dgvAutomobil.Rows[RowIndex].Cells[0].Value.ToString();
            txtProducator.Text = dgvAutomobil.Rows[RowIndex].Cells[1].Value.ToString(); 
            txtModel.Text = dgvAutomobil.Rows[RowIndex].Cells[2].Value.ToString();
            txtAnincepere.Text = dgvAutomobil.Rows[RowIndex].Cells[3].Value.ToString();
            txtAnincetare.Text = dgvAutomobil.Rows[RowIndex].Cells[4].Value.ToString();
            txtTip.Text = dgvAutomobil.Rows[RowIndex].Cells[5].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            a.Id = Convert.ToInt32(txtId.Text);
            a.Producator = txtProducator.Text;
            a.Model = txtModel.Text;
            a.Incepere = Convert.ToInt32(txtAnincepere.Text);
            a.Incetare = Convert.ToInt32(txtAnincetare.Text);
            a.Tip = txtTip.Text;


            bool succes = dal.Insert(a);

            if (succes)
            {
                MessageBox.Show("Automobilul a fost creat cu succes.");
                Clear();
                DataTable dt = dal.Select();
                dgvAutomobil.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Nu s-a putut crea noul automobil.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            a.Id = int.Parse(txtId.Text);
            a.Producator = txtProducator.Text;
            a.Model = txtModel.Text;
            a.Incepere = Convert.ToInt32(txtAnincepere.Text);
            a.Incetare = int.Parse(txtAnincetare.Text);
            a.Tip = txtTip.Text;

            bool succes = dal.Update(a);
            if (succes)
            {
                MessageBox.Show("Automobil actualizat cu succes.");
                Clear();
                DataTable dt = dal.Select();
                dgvAutomobil.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Automobilul nu a fost actualizat.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            a.Id = int.Parse(txtId.Text);

            bool succes = dal.Delete(a);

            if (succes)
            {
                MessageBox.Show("Automobil sters cu succes.");
                Clear();
                DataTable dt = dal.Select();
                dgvAutomobil.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Automobilul nu a fost sters.");
            }
        }
    }
}
