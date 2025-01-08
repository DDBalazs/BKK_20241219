namespace BKK_20241219
{
    partial class frmfo
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.buszjegyÉsBérletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vásárlástToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisztikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buszjegyÉsBérletToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // buszjegyÉsBérletToolStripMenuItem
            // 
            this.buszjegyÉsBérletToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vásárlástToolStripMenuItem,
            this.statisztikaToolStripMenuItem});
            this.buszjegyÉsBérletToolStripMenuItem.Name = "buszjegyÉsBérletToolStripMenuItem";
            this.buszjegyÉsBérletToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.buszjegyÉsBérletToolStripMenuItem.Text = "Buszjegy és bérlet";
            // 
            // vásárlástToolStripMenuItem
            // 
            this.vásárlástToolStripMenuItem.Name = "vásárlástToolStripMenuItem";
            this.vásárlástToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vásárlástToolStripMenuItem.Text = "Vásárlás";
            this.vásárlástToolStripMenuItem.Click += new System.EventHandler(this.vásárlástToolStripMenuItem_Click);
            // 
            // statisztikaToolStripMenuItem
            // 
            this.statisztikaToolStripMenuItem.Name = "statisztikaToolStripMenuItem";
            this.statisztikaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.statisztikaToolStripMenuItem.Text = "Statisztika";
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // frmfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Főform";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem buszjegyÉsBérletToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vásárlástToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisztikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
    }
}

