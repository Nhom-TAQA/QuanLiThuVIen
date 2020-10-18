namespace QL_TV
{
     partial class DS_DocGia
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

          #region Component Designer generated code

          /// <summary> 
          /// Required method for Designer support - do not modify 
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
               this.dtgvDocGia = new System.Windows.Forms.DataGridView();
               this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Ma_HocVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Ten_HocVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
               ((System.ComponentModel.ISupportInitialize)(this.dtgvDocGia)).BeginInit();
               this.SuspendLayout();
               // 
               // dtgvDocGia
               // 
               this.dtgvDocGia.AllowUserToAddRows = false;
               this.dtgvDocGia.AllowUserToResizeRows = false;
               this.dtgvDocGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.dtgvDocGia.BackgroundColor = System.Drawing.Color.White;
               dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
               dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
               dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
               dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
               dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
               dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
               this.dtgvDocGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
               this.dtgvDocGia.ColumnHeadersHeight = 40;
               this.dtgvDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
               this.dtgvDocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Ma_HocVien,
            this.Ten_HocVien,
            this.NgaySinh,
            this.Lop,
            this.Khoa});
               this.dtgvDocGia.Dock = System.Windows.Forms.DockStyle.Fill;
               this.dtgvDocGia.Location = new System.Drawing.Point(0, 0);
               this.dtgvDocGia.Name = "dtgvDocGia";
               this.dtgvDocGia.RowHeadersVisible = false;
               this.dtgvDocGia.RowHeadersWidth = 51;
               this.dtgvDocGia.RowTemplate.Height = 24;
               this.dtgvDocGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
               this.dtgvDocGia.Size = new System.Drawing.Size(1050, 485);
               this.dtgvDocGia.TabIndex = 1;
               // 
               // STT
               // 
               this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
               this.STT.FillWeight = 33.54891F;
               this.STT.HeaderText = "STT";
               this.STT.MinimumWidth = 6;
               this.STT.Name = "STT";
               this.STT.Width = 59;
               // 
               // Ma_HocVien
               // 
               this.Ma_HocVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
               this.Ma_HocVien.FillWeight = 97.18501F;
               this.Ma_HocVien.HeaderText = "Mã Học Viên";
               this.Ma_HocVien.MinimumWidth = 6;
               this.Ma_HocVien.Name = "Ma_HocVien";
               this.Ma_HocVien.Width = 169;
               // 
               // Ten_HocVien
               // 
               this.Ten_HocVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
               this.Ten_HocVien.FillWeight = 177.7458F;
               this.Ten_HocVien.HeaderText = "Tên Học Viên";
               this.Ten_HocVien.MinimumWidth = 6;
               this.Ten_HocVien.Name = "Ten_HocVien";
               this.Ten_HocVien.Width = 310;
               // 
               // NgaySinh
               // 
               this.NgaySinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
               this.NgaySinh.FillWeight = 128.3422F;
               this.NgaySinh.HeaderText = "Ngày Sinh";
               this.NgaySinh.MinimumWidth = 6;
               this.NgaySinh.Name = "NgaySinh";
               this.NgaySinh.Width = 224;
               // 
               // Lop
               // 
               this.Lop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
               this.Lop.FillWeight = 101.5749F;
               this.Lop.HeaderText = "Lớp";
               this.Lop.MinimumWidth = 6;
               this.Lop.Name = "Lop";
               this.Lop.Width = 178;
               // 
               // Khoa
               // 
               this.Khoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
               this.Khoa.FillWeight = 61.60323F;
               this.Khoa.HeaderText = "Khóa";
               this.Khoa.MinimumWidth = 6;
               this.Khoa.Name = "Khoa";
               this.Khoa.Width = 107;
               // 
               // DS_DocGia
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.Controls.Add(this.dtgvDocGia);
               this.Name = "DS_DocGia";
               this.Size = new System.Drawing.Size(1050, 485);
               ((System.ComponentModel.ISupportInitialize)(this.dtgvDocGia)).EndInit();
               this.ResumeLayout(false);

          }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_HocVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_HocVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoa;
        public System.Windows.Forms.DataGridView dtgvDocGia;
    }
}
