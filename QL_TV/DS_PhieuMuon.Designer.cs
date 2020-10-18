namespace QL_TV
{
     partial class DS_PhieuMuon
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
               this.dtgvPhieuMuon = new System.Windows.Forms.DataGridView();
               this.dtgvViewDL = new System.Windows.Forms.DataGridView();
               this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Ma_PhieuMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Ma_ThuThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Ma_HocVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
               ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuMuon)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dtgvViewDL)).BeginInit();
               this.SuspendLayout();
               // 
               // dtgvPhieuMuon
               // 
               this.dtgvPhieuMuon.BackgroundColor = System.Drawing.Color.White;
               this.dtgvPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dtgvPhieuMuon.Dock = System.Windows.Forms.DockStyle.Fill;
               this.dtgvPhieuMuon.GridColor = System.Drawing.Color.White;
               this.dtgvPhieuMuon.Location = new System.Drawing.Point(0, 0);
               this.dtgvPhieuMuon.Name = "dtgvPhieuMuon";
               this.dtgvPhieuMuon.RowHeadersWidth = 51;
               this.dtgvPhieuMuon.RowTemplate.Height = 24;
               this.dtgvPhieuMuon.Size = new System.Drawing.Size(1050, 485);
               this.dtgvPhieuMuon.TabIndex = 0;
               // 
               // dtgvViewDL
               // 
               this.dtgvViewDL.AllowUserToAddRows = false;
               this.dtgvViewDL.AllowUserToResizeRows = false;
               this.dtgvViewDL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.dtgvViewDL.BackgroundColor = System.Drawing.Color.White;
               dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
               dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
               dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
               dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
               dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
               dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
               this.dtgvViewDL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
               this.dtgvViewDL.ColumnHeadersHeight = 40;
               this.dtgvViewDL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
               this.dtgvViewDL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Ma_PhieuMuon,
            this.Ma_ThuThu,
            this.Ma_HocVien,
            this.NgayMuon});
               this.dtgvViewDL.Dock = System.Windows.Forms.DockStyle.Fill;
               this.dtgvViewDL.GridColor = System.Drawing.Color.White;
               this.dtgvViewDL.Location = new System.Drawing.Point(0, 0);
               this.dtgvViewDL.Margin = new System.Windows.Forms.Padding(2);
               this.dtgvViewDL.Name = "dtgvViewDL";
               this.dtgvViewDL.RowHeadersVisible = false;
               this.dtgvViewDL.RowHeadersWidth = 51;
               dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
               this.dtgvViewDL.RowsDefaultCellStyle = dataGridViewCellStyle2;
               this.dtgvViewDL.RowTemplate.Height = 24;
               this.dtgvViewDL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
               this.dtgvViewDL.Size = new System.Drawing.Size(1050, 485);
               this.dtgvViewDL.TabIndex = 4;
               // 
               // STT
               // 
               this.STT.FillWeight = 50.32479F;
               this.STT.HeaderText = "STT";
               this.STT.MinimumWidth = 6;
               this.STT.Name = "STT";
               // 
               // Ma_PhieuMuon
               // 
               this.Ma_PhieuMuon.FillWeight = 95.77705F;
               this.Ma_PhieuMuon.HeaderText = "Mã Phiếu Mượn";
               this.Ma_PhieuMuon.MinimumWidth = 6;
               this.Ma_PhieuMuon.Name = "Ma_PhieuMuon";
               // 
               // Ma_ThuThu
               // 
               this.Ma_ThuThu.FillWeight = 162.5875F;
               this.Ma_ThuThu.HeaderText = "Mã Nhân Viên";
               this.Ma_ThuThu.MinimumWidth = 6;
               this.Ma_ThuThu.Name = "Ma_ThuThu";
               // 
               // Ma_HocVien
               // 
               this.Ma_HocVien.FillWeight = 136.5929F;
               this.Ma_HocVien.HeaderText = "Mã Học Viên";
               this.Ma_HocVien.MinimumWidth = 6;
               this.Ma_HocVien.Name = "Ma_HocVien";
               // 
               // NgayMuon
               // 
               this.NgayMuon.FillWeight = 85.08578F;
               this.NgayMuon.HeaderText = "Ngày Mượn";
               this.NgayMuon.MinimumWidth = 6;
               this.NgayMuon.Name = "NgayMuon";
               // 
               // DS_PhieuMuon
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.LightYellow;
               this.Controls.Add(this.dtgvViewDL);
               this.Controls.Add(this.dtgvPhieuMuon);
               this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
               this.Name = "DS_PhieuMuon";
               this.Size = new System.Drawing.Size(1050, 485);
               ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuMuon)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dtgvViewDL)).EndInit();
               this.ResumeLayout(false);

          }

        #endregion

        private System.Windows.Forms.DataGridView dtgvPhieuMuon;
        public System.Windows.Forms.DataGridView dtgvViewDL;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_PhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_ThuThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_HocVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
    }
}
