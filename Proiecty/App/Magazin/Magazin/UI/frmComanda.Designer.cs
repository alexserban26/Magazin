
namespace Magazin.UI
{
    partial class frmComanda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComanda));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStare = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvComanda = new System.Windows.Forms.DataGridView();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtDataComanda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDataExpediere = new System.Windows.Forms.TextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.txtAdresaID = new System.Windows.Forms.TextBox();
            this.lbltip = new System.Windows.Forms.Label();
            this.txtComandaID = new System.Windows.Forms.TextBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.btnComenziMari = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComanda)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.pictureBoxClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1293, 39);
            this.panel1.TabIndex = 7;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(1261, 0);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 1;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(609, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comenzi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtStare
            // 
            this.txtStare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStare.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStare.Location = new System.Drawing.Point(116, 267);
            this.txtStare.Name = "txtStare";
            this.txtStare.Size = new System.Drawing.Size(205, 30);
            this.txtStare.TabIndex = 136;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(47, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 22);
            this.label9.TabIndex = 135;
            this.label9.Text = "Stare";
            // 
            // txtSuma
            // 
            this.txtSuma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSuma.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuma.Location = new System.Drawing.Point(116, 303);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(205, 30);
            this.txtSuma.TabIndex = 132;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 22);
            this.label6.TabIndex = 129;
            this.label6.Text = "Suma";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(331, 55);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(71, 22);
            this.lblSearch.TabIndex = 126;
            this.lblSearch.Text = "Cautare";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(408, 53);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(364, 30);
            this.txtSearch.TabIndex = 125;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvComanda
            // 
            this.dgvComanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComanda.Location = new System.Drawing.Point(408, 89);
            this.dgvComanda.Name = "dgvComanda";
            this.dgvComanda.RowHeadersWidth = 62;
            this.dgvComanda.RowTemplate.Height = 28;
            this.dgvComanda.Size = new System.Drawing.Size(875, 609);
            this.dgvComanda.TabIndex = 124;
            this.dgvComanda.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvComanda_RowHeaderMouseClick);
            // 
            // txtPrenume
            // 
            this.txtPrenume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrenume.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenume.Location = new System.Drawing.Point(116, 159);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.ReadOnly = true;
            this.txtPrenume.Size = new System.Drawing.Size(205, 30);
            this.txtPrenume.TabIndex = 123;
            // 
            // txtNume
            // 
            this.txtNume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNume.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNume.Location = new System.Drawing.Point(116, 123);
            this.txtNume.Name = "txtNume";
            this.txtNume.ReadOnly = true;
            this.txtNume.Size = new System.Drawing.Size(205, 30);
            this.txtNume.TabIndex = 122;
            // 
            // txtDataComanda
            // 
            this.txtDataComanda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataComanda.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataComanda.Location = new System.Drawing.Point(139, 195);
            this.txtDataComanda.Name = "txtDataComanda";
            this.txtDataComanda.Size = new System.Drawing.Size(182, 30);
            this.txtDataComanda.TabIndex = 121;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 22);
            this.label4.TabIndex = 120;
            this.label4.Text = "Data comanda";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 119;
            this.label2.Text = "Nume ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 118;
            this.label3.Text = "Prenume";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(35, 653);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(286, 43);
            this.btnDelete.TabIndex = 117;
            this.btnDelete.Text = "Stergere";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Red;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(35, 604);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(286, 43);
            this.btnUpdate.TabIndex = 116;
            this.btnUpdate.Text = "Modificare";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Red;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(35, 555);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(286, 43);
            this.btnAdd.TabIndex = 115;
            this.btnAdd.Text = "Adaugare";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDataExpediere
            // 
            this.txtDataExpediere.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataExpediere.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataExpediere.Location = new System.Drawing.Point(139, 231);
            this.txtDataExpediere.Name = "txtDataExpediere";
            this.txtDataExpediere.Size = new System.Drawing.Size(182, 30);
            this.txtDataExpediere.TabIndex = 114;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(-4, 53);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(109, 22);
            this.lblCod.TabIndex = 113;
            this.lblCod.Text = "Comanda ID";
            // 
            // txtAdresaID
            // 
            this.txtAdresaID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdresaID.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdresaID.Location = new System.Drawing.Point(116, 87);
            this.txtAdresaID.Name = "txtAdresaID";
            this.txtAdresaID.Size = new System.Drawing.Size(205, 30);
            this.txtAdresaID.TabIndex = 112;
            // 
            // lbltip
            // 
            this.lbltip.AutoSize = true;
            this.lbltip.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltip.Location = new System.Drawing.Point(3, 233);
            this.lbltip.Name = "lbltip";
            this.lbltip.Size = new System.Drawing.Size(130, 22);
            this.lbltip.TabIndex = 111;
            this.lbltip.Text = "Data expediere";
            // 
            // txtComandaID
            // 
            this.txtComandaID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComandaID.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComandaID.Location = new System.Drawing.Point(116, 51);
            this.txtComandaID.Name = "txtComandaID";
            this.txtComandaID.ReadOnly = true;
            this.txtComandaID.Size = new System.Drawing.Size(205, 30);
            this.txtComandaID.TabIndex = 110;
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.Location = new System.Drawing.Point(12, 87);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(92, 22);
            this.lblNume.TabIndex = 109;
            this.lblNume.Text = "Adresa ID";
            // 
            // btnComenziMari
            // 
            this.btnComenziMari.BackColor = System.Drawing.Color.Red;
            this.btnComenziMari.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComenziMari.Location = new System.Drawing.Point(778, 47);
            this.btnComenziMari.Name = "btnComenziMari";
            this.btnComenziMari.Size = new System.Drawing.Size(276, 38);
            this.btnComenziMari.TabIndex = 137;
            this.btnComenziMari.Text = "Comenzi peste 100 de lei";
            this.btnComenziMari.UseVisualStyleBackColor = false;
            this.btnComenziMari.Click += new System.EventHandler(this.btnComenziMari_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1060, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 38);
            this.button1.TabIndex = 138;
            this.button1.Text = "Toate Comenzile";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1293, 749);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnComenziMari);
            this.Controls.Add(this.txtStare);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSuma);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvComanda);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.txtDataComanda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDataExpediere);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.txtAdresaID);
            this.Controls.Add(this.lbltip);
            this.Controls.Add(this.txtComandaID);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmComanda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmComanda";
            this.Load += new System.EventHandler(this.frmComanda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComanda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStare;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvComanda;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtDataComanda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDataExpediere;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.TextBox txtAdresaID;
        private System.Windows.Forms.Label lbltip;
        private System.Windows.Forms.TextBox txtComandaID;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Button btnComenziMari;
        private System.Windows.Forms.Button button1;
    }
}