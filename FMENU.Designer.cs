namespace DE4QLHANGHOA_ADO
{
    partial class FMENU
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
            this.msDuLieu = new System.Windows.Forms.MenuStrip();
            this.MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchMặtHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpMặtHàngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.msDuLieu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msDuLieu
            // 
            this.msDuLieu.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.msDuLieu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem});
            this.msDuLieu.Location = new System.Drawing.Point(0, 0);
            this.msDuLieu.Name = "msDuLieu";
            this.msDuLieu.Size = new System.Drawing.Size(754, 27);
            this.msDuLieu.TabIndex = 0;
            this.msDuLieu.Text = "menuStrip1";
            // 
            // MenuItem
            // 
            this.MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchMặtHàngToolStripMenuItem,
            this.nhậpMặtHàngToolStripMenuItem1});
            this.MenuItem.Name = "MenuItem";
            this.MenuItem.Size = new System.Drawing.Size(99, 23);
            this.MenuItem.Text = "Nhập dữ liệu";
            // 
            // danhSáchMặtHàngToolStripMenuItem
            // 
            this.danhSáchMặtHàngToolStripMenuItem.Name = "danhSáchMặtHàngToolStripMenuItem";
            this.danhSáchMặtHàngToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.danhSáchMặtHàngToolStripMenuItem.Text = "Danh sách mặt hàng";
            this.danhSáchMặtHàngToolStripMenuItem.Click += new System.EventHandler(this.danhSáchMặtHàngToolStripMenuItem_Click);
            // 
            // nhậpMặtHàngToolStripMenuItem1
            // 
            this.nhậpMặtHàngToolStripMenuItem1.Name = "nhậpMặtHàngToolStripMenuItem1";
            this.nhậpMặtHàngToolStripMenuItem1.Size = new System.Drawing.Size(207, 24);
            this.nhậpMặtHàngToolStripMenuItem1.Text = "Nhập mặt hàng";
            this.nhậpMặtHàngToolStripMenuItem1.Click += new System.EventHandler(this.nhậpMặtHàngToolStripMenuItem1_Click);
            // 
            // FMENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 422);
            this.Controls.Add(this.msDuLieu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msDuLieu;
            this.Name = "FMENU";
            this.Text = "FMENU";
            this.msDuLieu.ResumeLayout(false);
            this.msDuLieu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msDuLieu;
        private System.Windows.Forms.ToolStripMenuItem MenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchMặtHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpMặtHàngToolStripMenuItem1;
    }
}