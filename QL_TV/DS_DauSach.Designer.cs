namespace QL_TV
{
     partial class DS_DauSach
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
               this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.NXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Ten_DauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Ma_DauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.dtgvViewDL = new System.Windows.Forms.DataGridView();
               ((System.ComponentModel.ISupportInitialize)(this.dtgvViewDL)).BeginInit();
               this.SuspendLayout();
               // 
               // SoLuong
               // 
               this.SoLuong.FillWeight = 69.63186F;
               this.SoLuong.HeaderText = "Số Lượng";
               this.SoLuong.MinimumWidth = 6;
               this.SoLuong.Name = "SoLuong";
               // 
               // NXB
               // 
               this.NXB.FillWeight = 91.00068F;
               this.NXB.HeaderText = "Nhà Xuất Bản";
               this.NXB.MinimumWidth = 6;
               this.NXB.Name = "NXB";
               // 
               // TacGia
               // 
               this.TacGia.FillWeight = 134.7785F;
               this.TacGia.HeaderText = "Tác Giả";
               this.TacGia.MinimumWidth = 6;
               this.TacGia.Name = "TacGia";
               // 
               // Ten_DauSach
               // 
               this.Ten_DauSach.FillWeight = 160.4278F;
               this.Ten_DauSach.HeaderText = "Tên Đầu Sách";
               this.Ten_DauSach.MinimumWidth = 6;
               this.Ten_DauSach.Name = "Ten_DauSach";
               // 
               // Ma_DauSach
               // 
               this.Ma_DauSach.FillWeight = 94.50479F;
               this.Ma_DauSach.HeaderText = "Mã Đầu Sách";
               this.Ma_DauSach.MinimumWidth = 6;
               this.Ma_DauSach.Name = "Ma_DauSach";
               // 
               // STT
               // 
               this.STT.FillWeight = 49.6563F;
               this.STT.HeaderText = "STT";
               this.STT.MinimumWidth = 6;
               this.STT.Name = "STT";
               // 
               // dtgvViewDL
               // 
               this.dtgvViewDL.AllowUserToAddRows = false;
               this.dtgvViewDL.AllowUserToResizeRows = false;
               this.dtgvViewDL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.dtgvViewDL.BackgroundColor = System.Drawing.Color.White;
               dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
               dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
               dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
               dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
               dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
               dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
               this.dtgvViewDL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
               this.dtgvViewDL.ColumnHeadersHeight = 40;
               this.dtgvViewDL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
               this.dtgvViewDL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Ma_DauSach,
            this.Ten_DauSach,
            this.TacGia,
            this.NXB,
            this.SoLuong});
               this.dtgvViewDL.Dock = System.Windows.Forms.DockStyle.Fill;
               this.dtgvViewDL.GridColor = System.Drawing.Color.White;
               this.dtgvViewDL.Location = new System.Drawing.Point(0, 0);
               this.dtgvViewDL.Margin = new System.Windows.Forms.Padding(2);
               this.dtgvViewDL.Name = "dtgvViewDL";
               this.dtgvViewDL.RowHeadersVisible = false;
               this.dtgvViewDL.RowHeadersWidth = 51;
               this.dtgvViewDL.RowTemplate.Height = 24;
               this.dtgvViewDL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
               this.dtgvViewDL.Size = new System.Drawing.Size(1050, 485);
               this.dtgvViewDL.TabIndex = 3;
               // 
               // DS_DauSach
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.LightYellow;
               this.Controls.Add(this.dtgvViewDL);
               this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.ForeColor = System.Drawing.Color.ForestGreen;
               this.Margin = new System.Windows.Forms.Padding(4);
               this.Name = "DS_DauSach";
               this.Size = new System.Drawing.Size(1050, 485);
               ((System.ComponentModel.ISupportInitialize)(this.dtgvViewDL)).EndInit();
               this.ResumeLayout(false);

          }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_DauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_DauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        public System.Windows.Forms.DataGridView dtgvViewDL;
    }
}
