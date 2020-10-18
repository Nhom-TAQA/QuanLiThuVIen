namespace QL_TV
{
     partial class CT_DauSach
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
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
               this.panel1 = new System.Windows.Forms.Panel();
               this.dtgvSach = new System.Windows.Forms.DataGridView();
               this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Ma_Sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.ViTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.TinhTrang = new System.Windows.Forms.DataGridViewCheckBoxColumn();
               this.panelInfor = new System.Windows.Forms.Panel();
               this.cbbDanhMuc = new System.Windows.Forms.ComboBox();
               this.btnQuayLai = new System.Windows.Forms.Button();
               this.btnXoa = new System.Windows.Forms.Button();
               this.btnSua = new System.Windows.Forms.Button();
               this.label1 = new System.Windows.Forms.Label();
               this.txbSoLuong = new System.Windows.Forms.TextBox();
               this.txbNXB = new System.Windows.Forms.TextBox();
               this.txbTacGia = new System.Windows.Forms.TextBox();
               this.txbTenDauSach = new System.Windows.Forms.TextBox();
               this.txbMaDauSach = new System.Windows.Forms.TextBox();
               this.lblSoLuong = new System.Windows.Forms.Label();
               this.lblNXB = new System.Windows.Forms.Label();
               this.lblTacGia = new System.Windows.Forms.Label();
               this.lblTenDauSach = new System.Windows.Forms.Label();
               this.lblMaDauSach = new System.Windows.Forms.Label();
               this.ptbAnhSach = new System.Windows.Forms.PictureBox();
               this.panel1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dtgvSach)).BeginInit();
               this.panelInfor.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.ptbAnhSach)).BeginInit();
               this.SuspendLayout();
               // 
               // panel1
               // 
               this.panel1.Controls.Add(this.dtgvSach);
               this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.panel1.Location = new System.Drawing.Point(0, 263);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(1048, 220);
               this.panel1.TabIndex = 4;
               // 
               // dtgvSach
               // 
               this.dtgvSach.AllowUserToAddRows = false;
               this.dtgvSach.AllowUserToResizeRows = false;
               this.dtgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.dtgvSach.BackgroundColor = System.Drawing.Color.White;
               dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
               dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
               dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
               dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
               dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
               dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
               this.dtgvSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
               this.dtgvSach.ColumnHeadersHeight = 40;
               this.dtgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
               this.dtgvSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Ma_Sach,
            this.ViTri,
            this.TinhTrang});
               this.dtgvSach.Dock = System.Windows.Forms.DockStyle.Fill;
               this.dtgvSach.Location = new System.Drawing.Point(0, 0);
               this.dtgvSach.Name = "dtgvSach";
               this.dtgvSach.RowHeadersVisible = false;
               this.dtgvSach.RowHeadersWidth = 51;
               this.dtgvSach.RowTemplate.Height = 24;
               this.dtgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
               this.dtgvSach.Size = new System.Drawing.Size(1048, 220);
               this.dtgvSach.TabIndex = 2;
               // 
               // STT
               // 
               this.STT.FillWeight = 42.78075F;
               this.STT.HeaderText = "STT";
               this.STT.MinimumWidth = 6;
               this.STT.Name = "STT";
               // 
               // Ma_Sach
               // 
               this.Ma_Sach.FillWeight = 119.0731F;
               this.Ma_Sach.HeaderText = "Mã Sách";
               this.Ma_Sach.MinimumWidth = 6;
               this.Ma_Sach.Name = "Ma_Sach";
               // 
               // ViTri
               // 
               this.ViTri.FillWeight = 119.0731F;
               this.ViTri.HeaderText = "Vị Trí";
               this.ViTri.MinimumWidth = 6;
               this.ViTri.Name = "ViTri";
               // 
               // TinhTrang
               // 
               this.TinhTrang.FillWeight = 119.0731F;
               this.TinhTrang.HeaderText = "Tình Trạng";
               this.TinhTrang.MinimumWidth = 6;
               this.TinhTrang.Name = "TinhTrang";
               // 
               // panelInfor
               // 
               this.panelInfor.BackColor = System.Drawing.Color.LightYellow;
               this.panelInfor.Controls.Add(this.cbbDanhMuc);
               this.panelInfor.Controls.Add(this.btnQuayLai);
               this.panelInfor.Controls.Add(this.btnXoa);
               this.panelInfor.Controls.Add(this.btnSua);
               this.panelInfor.Controls.Add(this.label1);
               this.panelInfor.Controls.Add(this.txbSoLuong);
               this.panelInfor.Controls.Add(this.txbNXB);
               this.panelInfor.Controls.Add(this.txbTacGia);
               this.panelInfor.Controls.Add(this.txbTenDauSach);
               this.panelInfor.Controls.Add(this.txbMaDauSach);
               this.panelInfor.Controls.Add(this.lblSoLuong);
               this.panelInfor.Controls.Add(this.lblNXB);
               this.panelInfor.Controls.Add(this.lblTacGia);
               this.panelInfor.Controls.Add(this.lblTenDauSach);
               this.panelInfor.Controls.Add(this.lblMaDauSach);
               this.panelInfor.Controls.Add(this.ptbAnhSach);
               this.panelInfor.Dock = System.Windows.Forms.DockStyle.Top;
               this.panelInfor.Location = new System.Drawing.Point(0, 0);
               this.panelInfor.Name = "panelInfor";
               this.panelInfor.Size = new System.Drawing.Size(1048, 263);
               this.panelInfor.TabIndex = 3;
               // 
               // cbbDanhMuc
               // 
               this.cbbDanhMuc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.cbbDanhMuc.FormattingEnabled = true;
               this.cbbDanhMuc.Location = new System.Drawing.Point(828, 19);
               this.cbbDanhMuc.Name = "cbbDanhMuc";
               this.cbbDanhMuc.Size = new System.Drawing.Size(168, 34);
               this.cbbDanhMuc.TabIndex = 16;
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
               this.btnQuayLai.TabIndex = 15;
               this.btnQuayLai.UseVisualStyleBackColor = false;
               // 
               // btnXoa
               // 
               this.btnXoa.BackColor = System.Drawing.Color.OrangeRed;
               this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnXoa.ForeColor = System.Drawing.Color.White;
               this.btnXoa.Location = new System.Drawing.Point(853, 206);
               this.btnXoa.Name = "btnXoa";
               this.btnXoa.Size = new System.Drawing.Size(143, 44);
               this.btnXoa.TabIndex = 14;
               this.btnXoa.Text = "Xóa";
               this.btnXoa.UseVisualStyleBackColor = false;
               // 
               // btnSua
               // 
               this.btnSua.BackColor = System.Drawing.Color.SeaGreen;
               this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnSua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnSua.ForeColor = System.Drawing.Color.White;
               this.btnSua.Location = new System.Drawing.Point(704, 206);
               this.btnSua.Name = "btnSua";
               this.btnSua.Size = new System.Drawing.Size(143, 44);
               this.btnSua.TabIndex = 11;
               this.btnSua.Text = "Sửa";
               this.btnSua.UseVisualStyleBackColor = false;
               this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.ForeColor = System.Drawing.Color.SeaGreen;
               this.label1.Location = new System.Drawing.Point(682, 19);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(114, 27);
               this.label1.TabIndex = 12;
               this.label1.Text = "Danh Mục";
               // 
               // txbSoLuong
               // 
               this.txbSoLuong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txbSoLuong.Location = new System.Drawing.Point(525, 212);
               this.txbSoLuong.Name = "txbSoLuong";
               this.txbSoLuong.Size = new System.Drawing.Size(140, 34);
               this.txbSoLuong.TabIndex = 10;
               // 
               // txbNXB
               // 
               this.txbNXB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txbNXB.Location = new System.Drawing.Point(525, 163);
               this.txbNXB.Name = "txbNXB";
               this.txbNXB.Size = new System.Drawing.Size(471, 34);
               this.txbNXB.TabIndex = 9;
               // 
               // txbTacGia
               // 
               this.txbTacGia.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txbTacGia.Location = new System.Drawing.Point(525, 114);
               this.txbTacGia.Name = "txbTacGia";
               this.txbTacGia.Size = new System.Drawing.Size(471, 34);
               this.txbTacGia.TabIndex = 8;
               // 
               // txbTenDauSach
               // 
               this.txbTenDauSach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txbTenDauSach.Location = new System.Drawing.Point(525, 65);
               this.txbTenDauSach.Name = "txbTenDauSach";
               this.txbTenDauSach.Size = new System.Drawing.Size(471, 34);
               this.txbTenDauSach.TabIndex = 7;
               // 
               // txbMaDauSach
               // 
               this.txbMaDauSach.Enabled = false;
               this.txbMaDauSach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txbMaDauSach.Location = new System.Drawing.Point(525, 16);
               this.txbMaDauSach.Name = "txbMaDauSach";
               this.txbMaDauSach.Size = new System.Drawing.Size(140, 34);
               this.txbMaDauSach.TabIndex = 6;
               this.txbMaDauSach.TabStop = false;
               // 
               // lblSoLuong
               // 
               this.lblSoLuong.AutoSize = true;
               this.lblSoLuong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.lblSoLuong.ForeColor = System.Drawing.Color.SeaGreen;
               this.lblSoLuong.Location = new System.Drawing.Point(360, 215);
               this.lblSoLuong.Name = "lblSoLuong";
               this.lblSoLuong.Size = new System.Drawing.Size(97, 27);
               this.lblSoLuong.TabIndex = 5;
               this.lblSoLuong.Text = "Số lượng";
               // 
               // lblNXB
               // 
               this.lblNXB.AutoSize = true;
               this.lblNXB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.lblNXB.ForeColor = System.Drawing.Color.SeaGreen;
               this.lblNXB.Location = new System.Drawing.Point(360, 167);
               this.lblNXB.Name = "lblNXB";
               this.lblNXB.Size = new System.Drawing.Size(141, 27);
               this.lblNXB.TabIndex = 4;
               this.lblNXB.Text = "Nhà xuất bản";
               // 
               // lblTacGia
               // 
               this.lblTacGia.AutoSize = true;
               this.lblTacGia.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.lblTacGia.ForeColor = System.Drawing.Color.SeaGreen;
               this.lblTacGia.Location = new System.Drawing.Point(360, 119);
               this.lblTacGia.Name = "lblTacGia";
               this.lblTacGia.Size = new System.Drawing.Size(88, 27);
               this.lblTacGia.TabIndex = 3;
               this.lblTacGia.Text = "Tác Giả";
               // 
               // lblTenDauSach
               // 
               this.lblTenDauSach.AutoSize = true;
               this.lblTenDauSach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.lblTenDauSach.ForeColor = System.Drawing.Color.SeaGreen;
               this.lblTenDauSach.Location = new System.Drawing.Point(360, 71);
               this.lblTenDauSach.Name = "lblTenDauSach";
               this.lblTenDauSach.Size = new System.Drawing.Size(147, 27);
               this.lblTenDauSach.TabIndex = 2;
               this.lblTenDauSach.Text = "Tên Đầu Sách";
               // 
               // lblMaDauSach
               // 
               this.lblMaDauSach.AutoSize = true;
               this.lblMaDauSach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.lblMaDauSach.ForeColor = System.Drawing.Color.SeaGreen;
               this.lblMaDauSach.Location = new System.Drawing.Point(360, 23);
               this.lblMaDauSach.Name = "lblMaDauSach";
               this.lblMaDauSach.Size = new System.Drawing.Size(142, 27);
               this.lblMaDauSach.TabIndex = 1;
               this.lblMaDauSach.Text = "Mã Đầu Sách";
               // 
               // ptbAnhSach
               // 
               this.ptbAnhSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.ptbAnhSach.Location = new System.Drawing.Point(91, 8);
               this.ptbAnhSach.Name = "ptbAnhSach";
               this.ptbAnhSach.Size = new System.Drawing.Size(246, 242);
               this.ptbAnhSach.TabIndex = 0;
               this.ptbAnhSach.TabStop = false;
               this.ptbAnhSach.Click += new System.EventHandler(this.ptbAnhSach_Click);
               // 
               // CT_DauSach
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.LightYellow;
               this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.Controls.Add(this.panel1);
               this.Controls.Add(this.panelInfor);
               this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.Margin = new System.Windows.Forms.Padding(4);
               this.Name = "CT_DauSach";
               this.Size = new System.Drawing.Size(1048, 483);
               this.panel1.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.dtgvSach)).EndInit();
               this.panelInfor.ResumeLayout(false);
               this.panelInfor.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.ptbAnhSach)).EndInit();
               this.ResumeLayout(false);

          }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_Sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViTri;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TinhTrang;
        private System.Windows.Forms.Panel panelInfor;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSoLuong;
        private System.Windows.Forms.TextBox txbNXB;
        private System.Windows.Forms.TextBox txbTacGia;
        private System.Windows.Forms.TextBox txbTenDauSach;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblNXB;
        private System.Windows.Forms.Label lblTacGia;
        private System.Windows.Forms.Label lblTenDauSach;
        private System.Windows.Forms.Label lblMaDauSach;
        private System.Windows.Forms.PictureBox ptbAnhSach;
        public System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.ComboBox cbbDanhMuc;
        public System.Windows.Forms.Button btnXoa;
          public System.Windows.Forms.TextBox txbMaDauSach;
     }
}
