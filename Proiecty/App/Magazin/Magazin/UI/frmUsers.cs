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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;

            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dgvClient.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgvClient.DataSource = dt;
            }
        }

        ClientBLL u = new ClientBLL();
        ClientDAL dal = new ClientDAL();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //get data from UI
            u.nume = txtNume.Text;
            u.prenume = txtPrenume.Text;
            u.contact = txtContact.Text;

            //inser data in database
            bool succes = dal.Insert(u);
            if (succes == true)
            {
                MessageBox.Show("Utilizator creat cu succes.");
                clear();
            }
            else
            {
                MessageBox.Show("Nu s-a putut crea un nou utilizator");
            }
            DataTable dt = dal.Select();
            dgvClient.DataSource = dt;
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvClient.DataSource = dt;
        }

        private void clear()
        { 
            txtNume.Text = "";
            txtPrenume.Text = "";
            txtContact.Text = "";
        }

        private void dgvClient_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Intoarce id-ul randului
            int rowIndex = e.RowIndex;
            txtClient_id.Text = dgvClient.Rows[rowIndex].Cells[0].Value.ToString();
            txtNume.Text = dgvClient.Rows[rowIndex].Cells[1].Value.ToString();
            txtPrenume.Text = dgvClient.Rows[rowIndex].Cells[2].Value.ToString();
            txtContact.Text = dgvClient.Rows[rowIndex].Cells[3].Value.ToString();

        }

       
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // get values from ui
            u.client_id = Convert.ToInt32(txtClient_id.Text);
            u.nume = txtNume.Text;
            u.prenume = txtPrenume.Text;
            u.contact = txtContact.Text;

            //update in database
            bool succes = dal.Update(u);
            if(succes==true)
            {
                MessageBox.Show("Informatiile clientului modificate cu succes");
            }
            else
            {
                MessageBox.Show("Informatiile nu au fost modificate");
            }
            DataTable dt = dal.Select();
            dgvClient.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            u.client_id = Convert.ToInt32(txtClient_id.Text);

            bool succes = dal.Delete(u);
            if (succes == true)
            {
                MessageBox.Show("Datele clientului au fost sterse cu succes.");
            }
            else
            {
                MessageBox.Show("Datele clientului NU au fost sterse.");
            }
            DataTable dt = dal.Select();
            dgvClient.DataSource = dt;

        }
    }
}
