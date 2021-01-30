
namespace Magazin
{
    partial class frmUserDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserDashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automobileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automobileCompatibileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSHead = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblAppFName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblfooter = new System.Windows.Forms.Label();
            this.lblLoggedIn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Red;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adresaToolStripMenuItem,
            this.comandaToolStripMenuItem,
            this.categoriiToolStripMenuItem,
            this.produseToolStripMenuItem,
            this.automobileToolStripMenuItem,
            this.automobileCompatibileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1412, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // adresaToolStripMenuItem
            // 
            this.adresaToolStripMenuItem.Name = "adresaToolStripMenuItem";
            this.adresaToolStripMenuItem.Size = new System.Drawing.Size(84, 28);
            this.adresaToolStripMenuItem.Text = "Adresa";
            // 
            // comandaToolStripMenuItem
            // 
            this.comandaToolStripMenuItem.Name = "comandaToolStripMenuItem";
            this.comandaToolStripMenuItem.Size = new System.Drawing.Size(106, 28);
            this.comandaToolStripMenuItem.Text = "Comanda";
            // 
            // categoriiToolStripMenuItem
            // 
            this.categoriiToolStripMenuItem.Name = "categoriiToolStripMenuItem";
            this.categoriiToolStripMenuItem.Size = new System.Drawing.Size(104, 28);
            this.categoriiToolStripMenuItem.Text = "Categorii";
            this.categoriiToolStripMenuItem.Click += new System.EventHandler(this.categoriiToolStripMenuItem_Click);
            // 
            // produseToolStripMenuItem
            // 
            this.produseToolStripMenuItem.Name = "produseToolStripMenuItem";
            this.produseToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.produseToolStripMenuItem.Text = "Produse";
            this.produseToolStripMenuItem.Click += new System.EventHandler(this.produseToolStripMenuItem_Click);
            // 
            // automobileToolStripMenuItem
            // 
            this.automobileToolStripMenuItem.Name = "automobileToolStripMenuItem";
            this.automobileToolStripMenuItem.Size = new System.Drawing.Size(123, 28);
            this.automobileToolStripMenuItem.Text = "Automobile";
            // 
            // automobileCompatibileToolStripMenuItem
            // 
            this.automobileCompatibileToolStripMenuItem.Name = "automobileCompatibileToolStripMenuItem";
            this.automobileCompatibileToolStripMenuItem.Size = new System.Drawing.Size(226, 28);
            this.automobileCompatibileToolStripMenuItem.Text = "Automobile compatibile";
            // 
            // lblSHead
            // 
            this.lblSHead.AutoEllipsis = true;
            this.lblSHead.AutoSize = true;
            this.lblSHead.BackColor = System.Drawing.Color.Red;
            this.lblSHead.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSHead.ForeColor = System.Drawing.Color.Black;
            this.lblSHead.Location = new System.Drawing.Point(456, 342);
            this.lblSHead.Name = "lblSHead";
            this.lblSHead.Size = new System.Drawing.Size(1114, 81);
            this.lblSHead.TabIndex = 12;
            this.lblSHead.Text = "Inregistrare si manipulare comenzi";
            // 
            // lblLName
            // 
            this.lblLName.AutoEllipsis = true;
            this.lblLName.AutoSize = true;
            this.lblLName.BackColor = System.Drawing.Color.Red;
            this.lblLName.Font = new System.Drawing.Font("Times New Roman", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.ForeColor = System.Drawing.Color.Black;
            this.lblLName.Location = new System.Drawing.Point(1029, 234);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(237, 108);
            this.lblLName.TabIndex = 11;
            this.lblLName.Text = "Auto";
            // 
            // lblAppFName
            // 
            this.lblAppFName.AutoEllipsis = true;
            this.lblAppFName.AutoSize = true;
            this.lblAppFName.BackColor = System.Drawing.Color.Red;
            this.lblAppFName.Font = new System.Drawing.Font("Times New Roman", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppFName.ForeColor = System.Drawing.Color.Black;
            this.lblAppFName.Location = new System.Drawing.Point(790, 234);
            this.lblAppFName.Name = "lblAppFName";
            this.lblAppFName.Size = new System.Drawing.Size(254, 108);
            this.lblAppFName.TabIndex = 10;
            this.lblAppFName.Text = "Piese";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-104, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Alex Serban";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUser.Location = new System.Drawing.Point(-176, 19);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(66, 19);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "Utilizator:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.lblfooter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 514);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1412, 36);
            this.panel1.TabIndex = 7;
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
            // lblLoggedIn
            // 
            this.lblLoggedIn.AutoSize = true;
            this.lblLoggedIn.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedIn.Location = new System.Drawing.Point(93, 31);
            this.lblLoggedIn.Name = "lblLoggedIn";
            this.lblLoggedIn.Size = new System.Drawing.Size(0, 23);
            this.lblLoggedIn.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(-4, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Utilizator:";
            // 
            // frmUserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1412, 550);
            this.Controls.Add(this.lblSHead);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblAppFName);
            this.Controls.Add(this.lblLoggedIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmUserDashboard";
            this.Text = "Utilizator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUserDashboard_FormClosed);
            this.Load += new System.EventHandler(this.frmUserDashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comandaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automobileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automobileCompatibileToolStripMenuItem;
        private System.Windows.Forms.Label lblSHead;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblAppFName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblfooter;
        private System.Windows.Forms.Label lblLoggedIn;
        private System.Windows.Forms.Label label3;
    }
}