namespace QL_TV
{
     partial class CT_PhieuMuon
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
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
               this.btnSua = new System.Windows.Forms.Button();
               this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
               this.lblNgaySinh = new System.Windows.Forms.Label();
               this.txbMaPhieuMuon = new System.Windows.Forms.TextBox();
               this.lblMaPhieuMuon = new System.Windows.Forms.Label();
               this.txbMaHocVien = new System.Windows.Forms.TextBox();
               this.txbMaNhanVien = new System.Windows.Forms.TextBox();
               this.lblMaHocVien = new System.Windows.Forms.Label();
               this.lblMaNhanVien = new System.Windows.Forms.Label();
               this.dtgvSach = new System.Windows.Forms.DataGridView();
               this.btnQuayLai = new System.Windows.Forms.Button();
               this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Ma_Sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.TinhTrang = new System.Windows.Forms.DataGridViewCheckBoxColumn();
               this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.btnXoa = new System.Windows.Forms.Button();
               ((System.ComponentModel.ISupportInitialize)(this.dtgvSach)).BeginInit();
               this.SuspendLayout();
               // 
               // btnSua
               // 
               this.btnSua.BackColor = System.Drawing.Color.ForestGreen;
               this.btnSua.FlatAppearance.BorderSize = 0;
               this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnSua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnSua.ForeColor = System.Drawing.Color.White;
               this.btnSua.Location = new System.Drawing.Point(77, 367);
               this.btnSua.Name = "btnSua";
               this.btnSua.Size = new System.Drawing.Size(119, 46);
               this.btnSua.TabIndex = 52;
               this.btnSua.Text = "Sửa";
               this.btnSua.UseVisualStyleBackColor = false;
               this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
               // 
               // dtpNgayMuon
               // 
               this.dtpNgayMuon.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
               this.dtpNgayMuon.Location = new System.Drawing.Point(234, 129);
               this.dtpNgayMuon.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
               this.dtpNgayMuon.Name = "dtpNgayMuon";
               this.dtpNgayMuon.Size = new System.Drawing.Size(156, 34);
               this.dtpNgayMuon.TabIndex = 51;
               // 
               // lblNgaySinh
               // 
               this.lblNgaySinh.AutoSize = true;
               this.lblNgaySinh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.lblNgaySinh.ForeColor = System.Drawing.Color.SeaGreen;
               this.lblNgaySinh.Location = new System.Drawing.Point(56, 132);
               this.lblNgaySinh.Name = "lblNgaySinh";
               this.lblNgaySinh.Size = new System.Drawing.Size(128, 27);
               this.lblNgaySinh.TabIndex = 50;
               this.lblNgaySinh.Text = "Ngày Mượn";
               // 
               // txbMaPhieuMuon
               // 
               this.txbMaPhieuMuon.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txbMaPhieuMuon.Location = new System.Drawing.Point(232, 55);
               this.txbMaPhieuMuon.Name = "txbMaPhieuMuon";
               this.txbMaPhieuMuon.ReadOnly = true;
               this.txbMaPhieuMuon.Size = new System.Drawing.Size(156, 34);
               this.txbMaPhieuMuon.TabIndex = 49;
               // 
               // lblMaPhieuMuon
               // 
               this.lblMaPhieuMuon.AutoSize = true;
               this.lblMaPhieuMuon.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.lblMaPhieuMuon.ForeColor = System.Drawing.Color.SeaGreen;
               this.lblMaPhieuMuon.Location = new System.Drawing.Point(56, 58);
               this.lblMaPhieuMuon.Name = "lblMaPhieuMuon";
               this.lblMaPhieuMuon.Size = new System.Drawing.Size(170, 27);
               this.lblMaPhieuMuon.TabIndex = 48;
               this.lblMaPhieuMuon.Text = "Mã Phiếu Mượn";
               // 
               // txbMaHocVien
               // 
               this.txbMaHocVien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txbMaHocVien.Location = new System.Drawing.Point(232, 277);
               this.txbMaHocVien.Name = "txbMaHocVien";
               this.txbMaHocVien.Size = new System.Drawing.Size(156, 34);
               this.txbMaHocVien.TabIndex = 47;
               // 
               // txbMaNhanVien
               // 
               this.txbMaNhanVien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txbMaNhanVien.Location = new System.Drawing.Point(232, 203);
               this.txbMaNhanVien.Name = "txbMaNhanVien";
               this.txbMaNhanVien.Size = new System.Drawing.Size(156, 34);
               this.txbMaNhanVien.TabIndex = 46;
               // 
               // lblMaHocVien
               // 
               this.lblMaHocVien.AutoSize = true;
               this.lblMaHocVien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.lblMaHocVien.ForeColor = System.Drawing.Color.SeaGreen;
               this.lblMaHocVien.Location = new System.Drawing.Point(56, 280);
               this.lblMaHocVien.Name = "lblMaHocVien";
               this.lblMaHocVien.Size = new System.Drawing.Size(140, 27);
               this.lblMaHocVien.TabIndex = 45;
               this.lblMaHocVien.Text = "Mã Học Viên";
               // 
               // lblMaNhanVien
               // 
               this.lblMaNhanVien.AutoSize = true;
               this.lblMaNhanVien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.lblMaNhanVien.ForeColor = System.Drawing.Color.SeaGreen;
               this.lblMaNhanVien.Location = new System.Drawing.Point(56, 206);
               this.lblMaNhanVien.Name = "lblMaNhanVien";
               this.lblMaNhanVien.Size = new System.Drawing.Size(152, 27);
               this.lblMaNhanVien.TabIndex = 44;
               this.lblMaNhanVien.Text = "Mã Nhân Viên";
               // 
               // dtgvSach
               // 
               this.dtgvSach.AllowUserToAddRows = false;
               this.dtgvSach.AllowUserToResizeRows = false;
               this.dtgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.dtgvSach.BackgroundColor = System.Drawing.Color.White;
               dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
               dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
               dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
               dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
               dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
               dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
               this.dtgvSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
               this.dtgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dtgvSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Ma_Sach,
            this.TinhTrang,
            this.NgayTra});
               this.dtgvSach.Dock = System.Windows.Forms.DockStyle.Right;
               this.dtgvSach.GridColor = System.Drawing.Color.White;
               this.dtgvSach.Location = new System.Drawing.Point(439, 0);
               this.dtgvSach.Name = "dtgvSach";
               dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
               dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
               dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
               dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
               dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
               dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
               this.dtgvSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
               this.dtgvSach.RowHeadersWidth = 51;
               this.dtgvSach.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
               dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
               this.dtgvSach.RowsDefaultCellStyle = dataGridViewCellStyle3;
               this.dtgvSach.RowTemplate.Height = 24;
               this.dtgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
               this.dtgvSach.Size = new System.Drawing.Size(609, 445);
               this.dtgvSach.TabIndex = 43;
               // 
               // btnQuayLai
               // 
               this.btnQuayLai.BackColor = System.Drawing.Color.Transparent;
               this.btnQuayLai.BackgroundImage = global::QL_TV.Properties.Resources.icons8_arrow_pointing_left_96;
               this.btnQuayLai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
               this.btnQuayLai.FlatAppearance.BorderSize = 0;
               this.btnQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnQuayLai.Location = new System.Drawing.Point(0, 0);
               this.btnQuayLai.Name = "btnQuayLai";
               this.btnQuayLai.Size = new System.Drawing.Size(58, 50);
               this.btnQuayLai.TabIndex = 53;
               this.btnQuayLai.UseVisualStyleBackColor = false;
               // 
               // STT
               // 
               this.STT.FillWeight = 74.86631F;
               this.STT.HeaderText = "STT";
               this.STT.MinimumWidth = 6;
               this.STT.Name = "STT";
               // 
               // Ma_Sach
               // 
               this.Ma_Sach.FillWeight = 153.3823F;
               this.Ma_Sach.HeaderText = "Ma Sách";
               this.Ma_Sach.MinimumWidth = 6;
               this.Ma_Sach.Name = "Ma_Sach";
               // 
               // TinhTrang
               // 
               this.TinhTrang.FillWeight = 85.87571F;
               this.TinhTrang.HeaderText = "Tình Trạng";
               this.TinhTrang.MinimumWidth = 6;
               this.TinhTrang.Name = "TinhTrang";
               // 
               // NgayTra
               // 
               this.NgayTra.FillWeight = 85.87571F;
               this.NgayTra.HeaderText = "Ngày Trả";
               this.NgayTra.MinimumWidth = 6;
               this.NgayTra.Name = "NgayTra";
               // 
               // btnXoa
               // 
               this.btnXoa.BackColor = System.Drawing.Color.OrangeRed;
               this.btnXoa.FlatAppearance.BorderSize = 0;
               this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnXoa.ForeColor = System.Drawing.Color.White;
               this.btnXoa.Location = new System.Drawing.Point(246, 367);
               this.btnXoa.Name = "btnXoa";
               this.btnXoa.Size = new System.Drawing.Size(119, 46);
               this.btnXoa.TabIndex = 54;
               this.btnXoa.Text = "Xóa";
               this.btnXoa.UseVisualStyleBackColor = false;
               // 
               // CT_PhieuMuon
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.LightYellow;
               this.Controls.Add(this.btnXoa);
               this.Controls.Add(this.btnQuayLai);
               this.Controls.Add(this.btnSua);
               this.Controls.Add(this.dtpNgayMuon);
               this.Controls.Add(this.lblNgaySinh);
               this.Controls.Add(this.txbMaPhieuMuon);
               this.Controls.Add(this.lblMaPhieuMuon);
               this.Controls.Add(this.txbMaHocVien);
               this.Controls.Add(this.txbMaNhanVien);
               this.Controls.Add(this.lblMaHocVien);
               this.Controls.Add(this.lblMaNhanVien);
               this.Controls.Add(this.dtgvSach);
               this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
               this.Name = "CT_PhieuMuon";
               this.Size = new System.Drawing.Size(1048, 445);
               ((System.ComponentModel.ISupportInitialize)(this.dtgvSach)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

        #endregion

        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblMaPhieuMuon;
        private System.Windows.Forms.TextBox txbMaHocVien;
        private System.Windows.Forms.TextBox txbMaNhanVien;
        private System.Windows.Forms.Label lblMaHocVien;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.DataGridView dtgvSach;
        public System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_Sach;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
        public System.Windows.Forms.Button btnXoa;
        public System.Windows.Forms.TextBox txbMaPhieuMuon;
    }
}
