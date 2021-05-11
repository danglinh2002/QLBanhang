namespace DE4QLHANGHOA_ADO
{
    partial class FMATHANG
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMathang = new System.Windows.Forms.DataGridView();
            this.cbLoai = new System.Windows.Forms.ComboBox();
            this.cbHang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmsMatHang = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hiểnThịThôngTinChiTiếtMặtHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaMặtHàngĐangChọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahanghoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmathang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMathang)).BeginInit();
            this.cmsMatHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMathang
            // 
            this.dgvMathang.AllowUserToAddRows = false;
            this.dgvMathang.AllowUserToDeleteRows = false;
            this.dgvMathang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMathang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMathang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMathang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.mahanghoa,
            this.tenmathang});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMathang.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMathang.Location = new System.Drawing.Point(73, 188);
            this.dgvMathang.Name = "dgvMathang";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMathang.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMathang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMathang.Size = new System.Drawing.Size(641, 258);
            this.dgvMathang.TabIndex = 8;
            this.dgvMathang.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMathang_CellMouseClick);
            this.dgvMathang.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvMathang_MouseDown);
            // 
            // cbLoai
            // 
            this.cbLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Location = new System.Drawing.Point(342, 88);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(248, 37);
            this.cbLoai.TabIndex = 7;
            this.cbLoai.SelectedIndexChanged += new System.EventHandler(this.cbLoai_SelectedIndexChanged);
            // 
            // cbHang
            // 
            this.cbHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHang.FormattingEnabled = true;
            this.cbHang.Location = new System.Drawing.Point(342, 33);
            this.cbHang.Name = "cbHang";
            this.cbHang.Size = new System.Drawing.Size(248, 37);
            this.cbHang.TabIndex = 6;
            this.cbHang.SelectedIndexChanged += new System.EventHandler(this.cbHang_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Danh sách mặt hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hãng sản xuất";
            // 
            // cmsMatHang
            // 
            this.cmsMatHang.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.cmsMatHang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hiểnThịThôngTinChiTiếtMặtHàngToolStripMenuItem,
            this.xóaMặtHàngĐangChọnToolStripMenuItem});
            this.cmsMatHang.Name = "cmsMatHang";
            this.cmsMatHang.Size = new System.Drawing.Size(296, 52);
            // 
            // hiểnThịThôngTinChiTiếtMặtHàngToolStripMenuItem
            // 
            this.hiểnThịThôngTinChiTiếtMặtHàngToolStripMenuItem.Name = "hiểnThịThôngTinChiTiếtMặtHàngToolStripMenuItem";
            this.hiểnThịThôngTinChiTiếtMặtHàngToolStripMenuItem.Size = new System.Drawing.Size(295, 24);
            this.hiểnThịThôngTinChiTiếtMặtHàngToolStripMenuItem.Text = "Hiển thị thông tin chi tiết mặt hàng";
            this.hiểnThịThôngTinChiTiếtMặtHàngToolStripMenuItem.Click += new System.EventHandler(this.hiểnThịThôngTinChiTiếtMặtHàngToolStripMenuItem_Click);
            // 
            // xóaMặtHàngĐangChọnToolStripMenuItem
            // 
            this.xóaMặtHàngĐangChọnToolStripMenuItem.Name = "xóaMặtHàngĐangChọnToolStripMenuItem";
            this.xóaMặtHàngĐangChọnToolStripMenuItem.Size = new System.Drawing.Size(295, 24);
            this.xóaMặtHàngĐangChọnToolStripMenuItem.Text = "Xóa mặt hàng đang chọn";
            this.xóaMặtHàngĐangChọnToolStripMenuItem.Click += new System.EventHandler(this.xóaMặtHàngĐangChọnToolStripMenuItem_Click);
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.Width = 55;
            // 
            // mahanghoa
            // 
            this.mahanghoa.DataPropertyName = "mahanghoa";
            this.mahanghoa.HeaderText = "Mã mặt hàng";
            this.mahanghoa.Name = "mahanghoa";
            this.mahanghoa.Visible = false;
            this.mahanghoa.Width = 96;
            // 
            // tenmathang
            // 
            this.tenmathang.DataPropertyName = "tenhanghoa";
            this.tenmathang.HeaderText = "Tên mặt hàng";
            this.tenmathang.Name = "tenmathang";
            // 
            // FMATHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 479);
            this.Controls.Add(this.dgvMathang);
            this.Controls.Add(this.cbLoai);
            this.Controls.Add(this.cbHang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FMATHANG";
            this.Text = "FMATHANG";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMathang)).EndInit();
            this.cmsMatHang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMathang;
        private System.Windows.Forms.ComboBox cbLoai;
        private System.Windows.Forms.ComboBox cbHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmsMatHang;
        private System.Windows.Forms.ToolStripMenuItem hiểnThịThôngTinChiTiếtMặtHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaMặtHàngĐangChọnToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahanghoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmathang;
    }
}