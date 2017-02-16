namespace JPKvalidator
{
    partial class ZakupyForm
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
            this.listViewZakupy = new System.Windows.Forms.ListView();
            this.cLp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cLpJPK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cNIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cNazwaDostawcy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cAdresDostawcy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDowodZak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDataZak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDataWpl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cK43 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cK44 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cK45 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cK46 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cK47 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cK48 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cK49 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cK50 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTyp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewZakupy
            // 
            this.listViewZakupy.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cLp,
            this.cLpJPK,
            this.cNIP,
            this.cNazwaDostawcy,
            this.cAdresDostawcy,
            this.cDowodZak,
            this.cDataZak,
            this.cDataWpl,
            this.cK43,
            this.cK44,
            this.cK45,
            this.cK46,
            this.cK47,
            this.cK48,
            this.cK49,
            this.cK50,
            this.cTyp});
            this.listViewZakupy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewZakupy.GridLines = true;
            this.listViewZakupy.Location = new System.Drawing.Point(0, 0);
            this.listViewZakupy.Name = "listViewZakupy";
            this.listViewZakupy.Size = new System.Drawing.Size(995, 261);
            this.listViewZakupy.TabIndex = 0;
            this.listViewZakupy.UseCompatibleStateImageBehavior = false;
            this.listViewZakupy.View = System.Windows.Forms.View.Details;
            // 
            // cLp
            // 
            this.cLp.Text = "Lp.";
            // 
            // cLpJPK
            // 
            this.cLpJPK.Text = "Lp. JPK";
            // 
            // cNIP
            // 
            this.cNIP.Text = "NIP";
            // 
            // cNazwaDostawcy
            // 
            this.cNazwaDostawcy.Text = "Nazwa dostawcy";
            // 
            // cAdresDostawcy
            // 
            this.cAdresDostawcy.Text = "Adres";
            // 
            // cDowodZak
            // 
            this.cDowodZak.Text = "Dowód Zakupu";
            // 
            // cDataZak
            // 
            this.cDataZak.Text = "Data zakupu";
            // 
            // cDataWpl
            // 
            this.cDataWpl.Text = "Data wpływu";
            // 
            // cK43
            // 
            this.cK43.Text = "K43";
            // 
            // cK44
            // 
            this.cK44.Text = "K44";
            // 
            // cK45
            // 
            this.cK45.Text = "K45";
            // 
            // cK46
            // 
            this.cK46.Text = "K46";
            // 
            // cK47
            // 
            this.cK47.Text = "K47";
            // 
            // cK48
            // 
            this.cK48.Text = "K48";
            // 
            // cK49
            // 
            this.cK49.Text = "K49";
            // 
            // cK50
            // 
            this.cK50.Text = "K50";
            // 
            // cTyp
            // 
            this.cTyp.Text = "typ";
            // 
            // ZakupyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 261);
            this.Controls.Add(this.listViewZakupy);
            this.Name = "ZakupyForm";
            this.Text = "Zakupy";
            this.Load += new System.EventHandler(this.ZakupyForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewZakupy;
        private System.Windows.Forms.ColumnHeader cLp;
        private System.Windows.Forms.ColumnHeader cLpJPK;
        private System.Windows.Forms.ColumnHeader cNIP;
        private System.Windows.Forms.ColumnHeader cNazwaDostawcy;
        private System.Windows.Forms.ColumnHeader cAdresDostawcy;
        private System.Windows.Forms.ColumnHeader cDowodZak;
        private System.Windows.Forms.ColumnHeader cDataZak;
        private System.Windows.Forms.ColumnHeader cDataWpl;
        private System.Windows.Forms.ColumnHeader cK43;
        private System.Windows.Forms.ColumnHeader cK44;
        private System.Windows.Forms.ColumnHeader cK45;
        private System.Windows.Forms.ColumnHeader cK46;
        private System.Windows.Forms.ColumnHeader cK47;
        private System.Windows.Forms.ColumnHeader cK48;
        private System.Windows.Forms.ColumnHeader cK49;
        private System.Windows.Forms.ColumnHeader cK50;
        private System.Windows.Forms.ColumnHeader cTyp;
    }
}