namespace JPKvalidator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStripMainMenu = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwóżToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowZakupy = new System.Windows.Forms.Button();
            this.btnShowSprzedaz = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.listJPK = new System.Windows.Forms.ListView();
            this.column1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnShowDekl = new System.Windows.Forms.Button();
            this.menuStripMainMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMainMenu
            // 
            this.menuStripMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStripMainMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainMenu.Name = "menuStripMainMenu";
            this.menuStripMainMenu.Size = new System.Drawing.Size(1250, 24);
            this.menuStripMainMenu.TabIndex = 1;
            this.menuStripMainMenu.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwóżToolStripMenuItem,
            this.zamknijToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // otwóżToolStripMenuItem
            // 
            this.otwóżToolStripMenuItem.Name = "otwóżToolStripMenuItem";
            this.otwóżToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.otwóżToolStripMenuItem.Text = "Otwórz plik JPK";
            this.otwóżToolStripMenuItem.Click += new System.EventHandler(this.otwóżToolStripMenuItem_Click);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnShowDekl);
            this.panel1.Controls.Add(this.btnShowZakupy);
            this.panel1.Controls.Add(this.btnShowSprzedaz);
            this.panel1.Controls.Add(this.btnUsun);
            this.panel1.Controls.Add(this.btnDodaj);
            this.panel1.Controls.Add(this.listJPK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 144);
            this.panel1.TabIndex = 3;
            // 
            // btnShowZakupy
            // 
            this.btnShowZakupy.Location = new System.Drawing.Point(369, 114);
            this.btnShowZakupy.Name = "btnShowZakupy";
            this.btnShowZakupy.Size = new System.Drawing.Size(94, 23);
            this.btnShowZakupy.TabIndex = 4;
            this.btnShowZakupy.Text = "Pokaż zakupy";
            this.btnShowZakupy.UseVisualStyleBackColor = true;
            this.btnShowZakupy.Click += new System.EventHandler(this.btnShowZakupy_Click);
            // 
            // btnShowSprzedaz
            // 
            this.btnShowSprzedaz.Location = new System.Drawing.Point(251, 113);
            this.btnShowSprzedaz.Name = "btnShowSprzedaz";
            this.btnShowSprzedaz.Size = new System.Drawing.Size(94, 23);
            this.btnShowSprzedaz.TabIndex = 3;
            this.btnShowSprzedaz.Text = "Pokaż sprzedaż";
            this.btnShowSprzedaz.UseVisualStyleBackColor = true;
            this.btnShowSprzedaz.Click += new System.EventHandler(this.btnShowSprzedaz_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(106, 113);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(94, 23);
            this.btnUsun.TabIndex = 2;
            this.btnUsun.Text = "Usuń plik JPK";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(6, 113);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(94, 23);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj plik JPK";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // listJPK
            // 
            this.listJPK.CheckBoxes = true;
            this.listJPK.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column1,
            this.column2,
            this.column3,
            this.column4,
            this.column5,
            this.column6,
            this.column7,
            this.column8,
            this.column9,
            this.column10,
            this.column11,
            this.column12,
            this.column13,
            this.column14,
            this.column15,
            this.column16});
            this.listJPK.Dock = System.Windows.Forms.DockStyle.Top;
            this.listJPK.GridLines = true;
            this.listJPK.Location = new System.Drawing.Point(0, 0);
            this.listJPK.Name = "listJPK";
            this.listJPK.Size = new System.Drawing.Size(1250, 107);
            this.listJPK.TabIndex = 0;
            this.listJPK.UseCompatibleStateImageBehavior = false;
            this.listJPK.View = System.Windows.Forms.View.Details;
            // 
            // column1
            // 
            this.column1.Text = "Lp.";
            this.column1.Width = 30;
            // 
            // column2
            // 
            this.column2.Text = "Nazwa Firmy";
            this.column2.Width = 400;
            // 
            // column3
            // 
            this.column3.Text = "NIP";
            this.column3.Width = 80;
            // 
            // column4
            // 
            this.column4.Text = "REGON";
            this.column4.Width = 80;
            // 
            // column5
            // 
            this.column5.Text = "Data od";
            this.column5.Width = 70;
            // 
            // column6
            // 
            this.column6.Text = "Data do";
            this.column6.Width = 70;
            // 
            // column7
            // 
            this.column7.Text = "Lp.z";
            this.column7.Width = 40;
            // 
            // column8
            // 
            this.column8.Text = "VAT naliczony";
            this.column8.Width = 85;
            // 
            // column9
            // 
            this.column9.Text = "Lp. s";
            this.column9.Width = 40;
            // 
            // column10
            // 
            this.column10.Text = "VAT należny";
            this.column10.Width = 85;
            // 
            // column11
            // 
            this.column11.Text = "Cel zł.";
            this.column11.Width = 45;
            // 
            // column12
            // 
            this.column12.Text = "KodU";
            this.column12.Width = 40;
            // 
            // column13
            // 
            this.column13.Text = "Data wytworzenia";
            this.column13.Width = 125;
            // 
            // column14
            // 
            this.column14.Text = "Kod form.";
            this.column14.Width = 160;
            // 
            // column15
            // 
            this.column15.Text = "Wariant";
            // 
            // column16
            // 
            this.column16.Text = "Waluta";
            // 
            // btnShowDekl
            // 
            this.btnShowDekl.Location = new System.Drawing.Point(559, 113);
            this.btnShowDekl.Name = "btnShowDekl";
            this.btnShowDekl.Size = new System.Drawing.Size(100, 23);
            this.btnShowDekl.TabIndex = 5;
            this.btnShowDekl.Text = "Pokaż deklaracje";
            this.btnShowDekl.UseVisualStyleBackColor = true;
            this.btnShowDekl.Click += new System.EventHandler(this.btnShowDekl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 555);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStripMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMainMenu;
            this.Name = "Form1";
            this.Text = "JPK validator";
            this.menuStripMainMenu.ResumeLayout(false);
            this.menuStripMainMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMainMenu;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwóżToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listJPK;
        private System.Windows.Forms.ColumnHeader column1;
        private System.Windows.Forms.ColumnHeader column2;
        private System.Windows.Forms.ColumnHeader column3;
        private System.Windows.Forms.ColumnHeader column4;
        private System.Windows.Forms.ColumnHeader column5;
        private System.Windows.Forms.ColumnHeader column6;
        private System.Windows.Forms.ColumnHeader column7;
        private System.Windows.Forms.ColumnHeader column8;
        private System.Windows.Forms.ColumnHeader column9;
        private System.Windows.Forms.ColumnHeader column10;
        private System.Windows.Forms.ColumnHeader column11;
        private System.Windows.Forms.ColumnHeader column12;
        private System.Windows.Forms.ColumnHeader column13;
        private System.Windows.Forms.ColumnHeader column14;
        private System.Windows.Forms.ColumnHeader column15;
        private System.Windows.Forms.ColumnHeader column16;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnShowSprzedaz;
        private System.Windows.Forms.Button btnShowZakupy;
        private System.Windows.Forms.Button btnShowDekl;
    }
}

