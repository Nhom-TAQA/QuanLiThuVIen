namespace QL_TV
{
     partial class ThemMoi_PhieuMuon
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
               this.dtgvSach = new System.Windows.Forms.DataGridView();
               this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Ma_Sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.txbHV = new System.Windows.Forms.TextBox();
               this.txbNV = new System.Windows.Forms.TextBox();
               this.lblMaHocVien = new System.Windows.Forms.Label();
               this.lblMaNhanVien = new System.Windows.Forms.Label();
               this.txbMaPhieuMuon = new System.Windows.Forms.TextBox();
               this.lblMaPhieuMuon = new System.Windows.Forms.Label();
               this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
               this.lblNgayMuon = new System.Windows.Forms.Label();
               this.btnXacNhan = new System.Windows.Forms.Button();
               this.txbMaSach = new System.Windows.Forms.TextBox();
               this.lblMaSach = new System.Windows.Forms.Label();
               this.btnThem = new System.Windows.Forms.Button();
               ((System.ComponentModel.ISupportInitialize)(this.dtgvSach)).BeginInit();
               this.SuspendLayout();
               // 
               // dtgvSach
               // 
               this.dtgvSach.AllowUserToAddRows = false;
               this.dtgvSach.AllowUserToResizeRows = false;
               this.dtgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.dtgvSach.BackgroundColor = System.Drawing.Color.White;
               this.dtgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dtgvSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Ma_Sach});
               this.dtgvSach.GridColor = System.Drawing.Color.White;
               this.dtgvSach.Location = new System.Drawing.Point(521, 88);
               this.dtgvSach.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
               this.dtgvSach.Name = "dtgvSach";
               this.dtgvSach.RowHeadersWidth = 51;
               this.dtgvSach.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
               this.dtgvSach.RowTemplate.Height = 24;
               this.dtgvSach.Size = new System.Drawing.Size(522, 395);
               this.dtgvSach.TabIndex = 0;
               // 
               // STT
               // 
               this.STT.FillWeight = 21.39038F;
               this.STT.HeaderText = "STT";
               this.STT.MinimumWidth = 6;
               this.STT.Name = "STT";
               // 
               // Ma_Sach
               // 
               this.Ma_Sach.FillWeight = 178.6096F;
               this.Ma_Sach.HeaderText = "Ma_Sach";
               this.Ma_Sach.MinimumWidth = 6;
               this.Ma_Sach.Name = "Ma_Sach";
               // 
               // txbHV
               // 
               this.txbHV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txbHV.Location = new System.Drawing.Point(224, 297);
               this.txbHV.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
               this.txbHV.Name = "txbHV";
               this.txbHV.Size = new System.Drawing.Size(243, 34);
               this.txbHV.TabIndex = 24;
               // 
               // txbNV
               // 
               this.txbNV.Enabled = false;
               this.txbNV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txbNV.Location = new System.Drawing.Point(224, 228);
               this.txbNV.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
               this.txbNV.Name = "txbNV";
               this.txbNV.Size = new System.Drawing.Size(243, 34);
               this.txbNV.TabIndex = 23;
               // 
               // lblMaHocVien
               // 
               this.lblMaHocVien.AutoSize = true;
               this.lblMaHocVien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.lblMaHocVien.ForeColor = System.Drawing.Color.SeaGreen;
               this.lblMaHocVien.Location = new System.Drawing.Point(40, 301);
               this.lblMaHocVien.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
               this.lblMaHocVien.Name = "lblMaHocVien";
               this.lblMaHocVien.Size = new System.Drawing.Size(140, 27);
               this.lblMaHocVien.TabIndex = 22;
               this.lblMaHocVien.Text = "Mã Học Viên";
               // 
               // lblMaNhanVien
               // 
               this.lblMaNhanVien.AutoSize = true;
               this.lblMaNhanVien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.lblMaNhanVien.ForeColor = System.Drawing.Color.SeaGreen;
               this.lblMaNhanVien.Location = new System.Drawing.Point(40, 232);
               this.lblMaNhanVien.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
               this.lblMaNhanVien.Name = "lblMaNhanVien";
               this.lblMaNhanVien.Size = new System.Drawing.Size(152, 27);
               this.lblMaNhanVien.TabIndex = 21;
               this.lblMaNhanVien.Text = "Mã Nhân Viên";
               // 
               // txbMaPhieuMuon
               // 
               this.txbMaPhieuMuon.Enabled = false;
               this.txbMaPhieuMuon.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txbMaPhieuMuon.Location = new System.Drawing.Point(224, 88);
               this.txbMaPhieuMuon.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
               this.txbMaPhieuMuon.Name = "txbMaPhieuMuon";
               this.txbMaPhieuMuon.ReadOnly = true;
               this.txbMaPhieuMuon.Size = new System.Drawing.Size(243, 34);
               this.txbMaPhieuMuon.TabIndex = 26;
               // 
               // lblMaPhieuMuon
               // 
               this.lblMaPhieuMuon.AutoSize = true;
               this.lblMaPhieuMuon.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.lblMaPhieuMuon.ForeColor = System.Drawing.Color.SeaGreen;
               this.lblMaPhieuMuon.Location = new System.Drawing.Point(40, 92);
               this.lblMaPhieuMuon.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
               this.lblMaPhieuMuon.Name = "lblMaPhieuMuon";
               this.lblMaPhieuMuon.Size = new System.Drawing.Size(170, 27);
               this.lblMaPhieuMuon.TabIndex = 25;
               this.lblMaPhieuMuon.Text = "Mã Phiếu Mượn";
               // 
               // dtpNgayMuon
               // 
               this.dtpNgayMuon.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
               this.dtpNgayMuon.Location = new System.Drawing.Point(224, 158);
               this.dtpNgayMuon.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
               this.dtpNgayMuon.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
               this.dtpNgayMuon.Name = "dtpNgayMuon";
               this.dtpNgayMuon.Size = new System.Drawing.Size(243, 34);
               this.dtpNgayMuon.TabIndex = 41;
               // 
               // lblNgayMuon
               // 
               this.lblNgayMuon.AutoSize = true;
               this.lblNgayMuon.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.lblNgayMuon.ForeColor = System.Drawing.Color.SeaGreen;
               this.lblNgayMuon.Location = new System.Drawing.Point(40, 158);
               this.lblNgayMuon.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
               this.lblNgayMuon.Name = "lblNgayMuon";
               this.lblNgayMuon.Size = new System.Drawing.Size(128, 27);
               this.lblNgayMuon.TabIndex = 40;
               this.lblNgayMuon.Text = "Ngày Mượn";
               // 
               // btnXacNhan
               // 
               this.btnXacNhan.BackColor = System.Drawing.Color.ForestGreen;
               this.btnXacNhan.FlatAppearance.BorderSize = 0;
               this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnXacNhan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnXacNhan.ForeColor = System.Drawing.Color.White;
               this.btnXacNhan.Location = new System.Drawing.Point(115, 396);
               this.btnXacNhan.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
               this.btnXacNhan.Name = "btnXacNhan";
               this.btnXacNhan.Size = new System.Drawing.Size(244, 58);
               this.btnXacNhan.TabIndex = 42;
               this.btnXacNhan.Text = "Xác Nhận";
               this.btnXacNhan.UseVisualStyleBackColor = false;
               this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
               // 
               // txbMaSach
               // 
               this.txbMaSach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txbMaSach.Location = new System.Drawing.Point(665, 28);
               this.txbMaSach.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
               this.txbMaSach.Name = "txbMaSach";
               this.txbMaSach.Size = new System.Drawing.Size(194, 34);
               this.txbMaSach.TabIndex = 44;
               // 
               // lblMaSach
               // 
               this.lblMaSach.AutoSize = true;
               this.lblMaSach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.lblMaSach.ForeColor = System.Drawing.Color.SeaGreen;
               this.lblMaSach.Location = new System.Drawing.Point(537, 28);
               this.lblMaSach.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
               this.lblMaSach.Name = "lblMaSach";
               this.lblMaSach.Size = new System.Drawing.Size(96, 27);
               this.lblMaSach.TabIndex = 43;
               this.lblMaSach.Text = "Mã Sách";
               // 
               // btnThem
               // 
               this.btnThem.BackColor = System.Drawing.Color.ForestGreen;
               this.btnThem.FlatAppearance.BorderSize = 0;
               this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnThem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnThem.ForeColor = System.Drawing.Color.White;
               this.btnThem.Location = new System.Drawing.Point(910, 21);
               this.btnThem.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
               this.btnThem.Name = "btnThem";
               this.btnThem.Size = new System.Drawing.Size(108, 47);
               this.btnThem.TabIndex = 45;
               this.btnThem.Text = "Thêm";
               this.btnThem.UseVisualStyleBackColor = false;
               this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
               // 
               // ThemMoi_PhieuMuon
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.LightYellow;
               this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.Controls.Add(this.btnThem);
               this.Controls.Add(this.txbMaSach);
               this.Controls.Add(this.lblMaSach);
               this.Controls.Add(this.btnXacNhan);
               this.Controls.Add(this.dtpNgayMuon);
               this.Controls.Add(this.lblNgayMuon);
               this.Controls.Add(this.txbMaPhieuMuon);
               this.Controls.Add(this.lblMaPhieuMuon);
               this.Controls.Add(this.txbHV);
               this.Controls.Add(this.txbNV);
               this.Controls.Add(this.lblMaHocVien);
               this.Controls.Add(this.lblMaNhanVien);
               this.Controls.Add(this.dtgvSach);
               this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
               this.Name = "ThemMoi_PhieuMuon";
               this.Size = new System.Drawing.Size(1046, 481);
               ((System.ComponentModel.ISupportInitialize)(this.dtgvSach)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

        #endregion

        private System.Windows.Forms.DataGridView dtgvSach;
        private System.Windows.Forms.TextBox txbHV;
        private System.Windows.Forms.TextBox txbNV;
        private System.Windows.Forms.Label lblMaHocVien;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.TextBox txbMaPhieuMuon;
        private System.Windows.Forms.Label lblMaPhieuMuon;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.Label lblNgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_Sach;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.TextBox txbMaSach;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.Button btnThem;
    }
}
