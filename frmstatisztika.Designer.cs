namespace BKK_20241219
{
    partial class frmstatisztika
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
            this.dgadatok = new System.Windows.Forms.DataGridView();
            this.vdb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vosszeg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tosszeg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosszeg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.osszeg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgadatok)).BeginInit();
            this.SuspendLayout();
            // 
            // dgadatok
            // 
            this.dgadatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgadatok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vdb,
            this.vosszeg,
            this.tdb,
            this.tosszeg,
            this.ddb,
            this.dosszeg,
            this.osszeg});
            this.dgadatok.Location = new System.Drawing.Point(12, 36);
            this.dgadatok.Name = "dgadatok";
            this.dgadatok.Size = new System.Drawing.Size(759, 376);
            this.dgadatok.TabIndex = 0;
            // 
            // vdb
            // 
            this.vdb.HeaderText = "Vendégjegyek száma [db]";
            this.vdb.Name = "vdb";
            this.vdb.ReadOnly = true;
            // 
            // vosszeg
            // 
            this.vosszeg.HeaderText = "Vendégjegyek értéke [Ft]";
            this.vosszeg.Name = "vosszeg";
            this.vosszeg.ReadOnly = true;
            // 
            // tdb
            // 
            this.tdb.HeaderText = "Teljes árú jegyek száma [db]";
            this.tdb.Name = "tdb";
            this.tdb.ReadOnly = true;
            // 
            // tosszeg
            // 
            this.tosszeg.HeaderText = "Teljes árú jegyek értéke [Ft]";
            this.tosszeg.Name = "tosszeg";
            this.tosszeg.ReadOnly = true;
            // 
            // ddb
            // 
            this.ddb.HeaderText = "Diákjegyek száma";
            this.ddb.Name = "ddb";
            this.ddb.ReadOnly = true;
            // 
            // dosszeg
            // 
            this.dosszeg.HeaderText = "Diákjegyek értéke [Ft]";
            this.dosszeg.Name = "dosszeg";
            this.dosszeg.ReadOnly = true;
            // 
            // osszeg
            // 
            this.osszeg.HeaderText = "Végösszeg [Ft]";
            this.osszeg.Name = "osszeg";
            this.osszeg.ReadOnly = true;
            // 
            // frmstatisztika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgadatok);
            this.Name = "frmstatisztika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statisztika";
            this.Load += new System.EventHandler(this.frmstatisztika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgadatok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgadatok;
        private System.Windows.Forms.DataGridViewTextBoxColumn vdb;
        private System.Windows.Forms.DataGridViewTextBoxColumn vosszeg;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdb;
        private System.Windows.Forms.DataGridViewTextBoxColumn tosszeg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ddb;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosszeg;
        private System.Windows.Forms.DataGridViewTextBoxColumn osszeg;
    }
}