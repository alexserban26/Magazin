
namespace Magazin
{
    partial class frmAdminDashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblfooter = new System.Windows.Forms.Label();
            this.lblLogedInUser = new System.Windows.Forms.Label();
            this.lblAppFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblSHead = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.utilizatoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adreseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comenziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produseComandateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.furnizoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automobileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automobileCompatibileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.lblfooter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 414);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1601, 36);
            this.panel1.TabIndex = 0;
            // 
            // lblfooter
            // 
            this.lblfooter.AutoSize = true;
            this.lblfooter.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfooter.Location = new System.Drawing.Point(12, 8);
            this.lblfooter.Name = "lblfooter";
            this.lblfooter.Size = new System.Drawing.Size(118, 19);
            this.lblfooter.TabIndex = 0;
            this.lblfooter.Text = "Developed by AS";
            // 
            // lblLogedInUser
            // 
            this.lblLogedInUser.AutoSize = true;
            this.lblLogedInUser.BackColor = System.Drawing.Color.Red;
            this.lblLogedInUser.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogedInUser.ForeColor = System.Drawing.Color.Black;
            this.lblLogedInUser.Location = new System.Drawing.Point(99, 37);
            this.lblLogedInUser.Name = "lblLogedInUser";
            this.lblLogedInUser.Size = new System.Drawing.Size(0, 22);
            this.lblLogedInUser.TabIndex = 3;
            this.lblLogedInUser.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblAppFName
            // 
            this.lblAppFName.AutoSize = true;
            this.lblAppFName.BackColor = System.Drawing.Color.Red;
            this.lblAppFName.Font = new System.Drawing.Font("Times New Roman", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppFName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblAppFName.Location = new System.Drawing.Point(705, 270);
            this.lblAppFName.Name = "lblAppFName";
            this.lblAppFName.Size = new System.Drawing.Size(254, 108);
            this.lblAppFName.TabIndex = 4;
            this.lblAppFName.Text = "Piese";
            this.lblAppFName.Click += new System.EventHandler(this.lblAppFName_Click);
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.BackColor = System.Drawing.Color.Red;
            this.lblLName.Font = new System.Drawing.Font("Times New Roman", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblLName.Location = new System.Drawing.Point(949, 270);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(237, 108);
            this.lblLName.TabIndex = 5;
            this.lblLName.Text = "Auto";
            this.lblLName.Click += new System.EventHandler(this.lblLName_Click);
            // 
            // lblSHead
            // 
            this.lblSHead.AutoSize = true;
            this.lblSHead.BackColor = System.Drawing.Color.Red;
            this.lblSHead.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSHead.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblSHead.Location = new System.Drawing.Point(448, 369);
            this.lblSHead.Name = "lblSHead";
            this.lblSHead.Size = new System.Drawing.Size(1114, 81);
            this.lblSHead.TabIndex = 6;
            this.lblSHead.Text = "Inregistrare si manipulare comenzi";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Red;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilizatoriToolStripMenuItem,
            this.adreseToolStripMenuItem,
            this.comenziToolStripMenuItem,
            this.produseComandateToolStripMenuItem,
            this.categoriiToolStripMenuItem,
            this.produseToolStripMenuItem,
            this.furnizoriToolStripMenuItem,
            this.automobileToolStripMenuItem,
            this.automobileCompatibileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1601, 36);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // utilizatoriToolStripMenuItem
            // 
            this.utilizatoriToolStripMenuItem.Name = "utilizatoriToolStripMenuItem";
            this.utilizatoriToolStripMenuItem.Size = new System.Drawing.Size(129, 32);
            this.utilizatoriToolStripMenuItem.Text = "Utilizatori";
            this.utilizatoriToolStripMenuItem.Click += new System.EventHandler(this.utilizatoriToolStripMenuItem_Click_1);
            // 
            // adreseToolStripMenuItem
            // 
            this.adreseToolStripMenuItem.Name = "adreseToolStripMenuItem";
            this.adreseToolStripMenuItem.Size = new System.Drawing.Size(96, 32);
            this.adreseToolStripMenuItem.Text = "Adrese";
            this.adreseToolStripMenuItem.Click += new System.EventHandler(this.adreseToolStripMenuItem_Click);
            // 
            // comenziToolStripMenuItem
            // 
            this.comenziToolStripMenuItem.Name = "comenziToolStripMenuItem";
            this.comenziToolStripMenuItem.Size = new System.Drawing.Size(114, 32);
            this.comenziToolStripMenuItem.Text = "Comenzi";
            this.comenziToolStripMenuItem.Click += new System.EventHandler(this.comenziToolStripMenuItem_Click);
            // 
            // produseComandateToolStripMenuItem
            // 
            this.produseComandateToolStripMenuItem.Name = "produseComandateToolStripMenuItem";
            this.produseComandateToolStripMenuItem.Size = new System.Drawing.Size(228, 32);
            this.produseComandateToolStripMenuItem.Text = "Produse Comandate";
            this.produseComandateToolStripMenuItem.Click += new System.EventHandler(this.produseComandateToolStripMenuItem_Click);
            // 
            // categoriiToolStripMenuItem
            // 
            this.categoriiToolStripMenuItem.Name = "categoriiToolStripMenuItem";
            this.categoriiToolStripMenuItem.Size = new System.Drawing.Size(121, 32);
            this.categoriiToolStripMenuItem.Text = "Categorii";
            this.categoriiToolStripMenuItem.Click += new System.EventHandler(this.categoriiToolStripMenuItem_Click);
            // 
            // produseToolStripMenuItem
            // 
            this.produseToolStripMenuItem.Name = "produseToolStripMenuItem";
            this.produseToolStripMenuItem.Size = new System.Drawing.Size(109, 32);
            this.produseToolStripMenuItem.Text = "Produse";
            this.produseToolStripMenuItem.Click += new System.EventHandler(this.produseToolStripMenuItem_Click);
            // 
            // furnizoriToolStripMenuItem
            // 
            this.furnizoriToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.furnizoriToolStripMenuItem.Name = "furnizoriToolStripMenuItem";
            this.furnizoriToolStripMenuItem.Size = new System.Drawing.Size(123, 32);
            this.furnizoriToolStripMenuItem.Text = "Furnizori";
            this.furnizoriToolStripMenuItem.Click += new System.EventHandler(this.furnizoriToolStripMenuItem_Click);
            // 
            // automobileToolStripMenuItem
            // 
            this.automobileToolStripMenuItem.Name = "automobileToolStripMenuItem";
            this.automobileToolStripMenuItem.Size = new System.Drawing.Size(143, 32);
            this.automobileToolStripMenuItem.Text = "Automobile";
            this.automobileToolStripMenuItem.Click += new System.EventHandler(this.automobileToolStripMenuItem_Click);
            // 
            // automobileCompatibileToolStripMenuItem
            // 
            this.automobileCompatibileToolStripMenuItem.Name = "automobileCompatibileToolStripMenuItem";
            this.automobileCompatibileToolStripMenuItem.Size = new System.Drawing.Size(270, 32);
            this.automobileCompatibileToolStripMenuItem.Text = "Automobile Compatibile";
            this.automobileCompatibileToolStripMenuItem.Click += new System.EventHandler(this.automobileCompatibileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(16, 32);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(16, 32);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(16, 32);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(16, 32);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1601, 450);
            this.Controls.Add(this.lblSHead);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblAppFName);
            this.Controls.Add(this.lblLogedInUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdminDashboard_FormClosed);
            this.Load += new System.EventHandler(this.lblLogedInUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblfooter;
        private System.Windows.Forms.Label lblLogedInUser;
        private System.Windows.Forms.Label lblAppFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblSHead;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem utilizatoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriiToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem produseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem furnizoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automobileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automobileCompatibileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adreseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produseComandateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem comenziToolStripMenuItem;
    }
}

