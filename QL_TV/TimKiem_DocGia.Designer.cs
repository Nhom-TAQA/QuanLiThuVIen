namespace QL_TV
{
     partial class TimKiem_DocGia
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
               this.panelShowKQ = new System.Windows.Forms.Panel();
               this.panelBar = new System.Windows.Forms.Panel();
               this.cbbPhanLoai = new System.Windows.Forms.ComboBox();
               this.txbTimKiem = new System.Windows.Forms.TextBox();
               this.lblTheo = new System.Windows.Forms.Label();
               this.lblNoiDung = new System.Windows.Forms.Label();
               this.btnTimKiem = new System.Windows.Forms.Button();
               this.panelBar.SuspendLayout();
               this.SuspendLayout();
               // 
               // panelShowKQ
               // 
               this.panelShowKQ.Dock = System.Windows.Forms.DockStyle.Fill;
               this.panelShowKQ.Location = new System.Drawing.Point(0, 60);
               this.panelShowKQ.Name = "panelShowKQ";
               this.panelShowKQ.Size = new System.Drawing.Size(1048, 423);
               this.panelShowKQ.TabIndex = 3;
               // 
               // panelBar
               // 
               this.panelBar.Controls.Add(this.cbbPhanLoai);
               this.panelBar.Controls.Add(this.txbTimKiem);
               this.panelBar.Controls.Add(this.lblTheo);
               this.panelBar.Controls.Add(this.lblNoiDung);
               this.panelBar.Controls.Add(this.btnTimKiem);
               this.panelBar.Dock = System.Windows.Forms.DockStyle.Top;
               this.panelBar.Location = new System.Drawing.Point(0, 0);
               this.panelBar.Name = "panelBar";
               this.panelBar.Size = new System.Drawing.Size(1048, 60);
               this.panelBar.TabIndex = 2;
               // 
               // cbbPhanLoai
               // 
               this.cbbPhanLoai.AutoCompleteCustomSource.AddRange(new string[] {
            "Mã Học Viên",
            "Tên Học Viên",
            "Ngày Sinh",
            "Lớp",
            "Khóa"});
               this.cbbPhanLoai.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.cbbPhanLoai.FormattingEnabled = true;
               this.cbbPhanLoai.Items.AddRange(new object[] {
            "Mã Học Viên",
            "Tên Học Viên",
            "Ngày Sinh",
            "Lớp",
            "Khóa"});
               this.cbbPhanLoai.Location = new System.Drawing.Point(678, 14);
               this.cbbPhanLoai.Name = "cbbPhanLoai";
               this.cbbPhanLoai.Size = new System.Drawing.Size(224, 34);
               this.cbbPhanLoai.TabIndex = 4;
               // 
               // txbTimKiem
               // 
               this.txbTimKiem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txbTimKiem.Location = new System.Drawing.Point(143, 14);
               this.txbTimKiem.Name = "txbTimKiem";
               this.txbTimKiem.Size = new System.Drawing.Size(436, 34);
               this.txbTimKiem.TabIndex = 3;
               // 
               // lblTheo
               // 
               this.lblTheo.AutoSize = true;
               this.lblTheo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.lblTheo.Location = new System.Drawing.Point(595, 17);
               this.lblTheo.Name = "lblTheo";
               this.lblTheo.Size = new System.Drawing.Size(67, 27);
               this.lblTheo.TabIndex = 2;
               this.lblTheo.Text = "Theo:";
               // 
               // lblNoiDung
               // 
               this.lblNoiDung.AutoSize = true;
               this.lblNoiDung.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.lblNoiDung.Location = new System.Drawing.Point(18, 17);
               this.lblNoiDung.Name = "lblNoiDung";
               this.lblNoiDung.Size = new System.Drawing.Size(109, 27);
               this.lblNoiDung.TabIndex = 1;
               this.lblNoiDung.Text = "Tìm kiếm:";
               // 
               // btnTimKiem
               // 
               this.btnTimKiem.BackColor = System.Drawing.Color.ForestGreen;
               this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnTimKiem.ForeColor = System.Drawing.Color.White;
               this.btnTimKiem.Location = new System.Drawing.Point(918, 11);
               this.btnTimKiem.Name = "btnTimKiem";
               this.btnTimKiem.Size = new System.Drawing.Size(113, 37);
               this.btnTimKiem.TabIndex = 0;
               this.btnTimKiem.Text = "Tìm kiếm";
               this.btnTimKiem.UseVisualStyleBackColor = false;
               this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
               // 
               // TimKiem_DocGia
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.LightYellow;
               this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.Controls.Add(this.panelShowKQ);
               this.Controls.Add(this.panelBar);
               this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.ForeColor = System.Drawing.Color.ForestGreen;
               this.Margin = new System.Windows.Forms.Padding(4);
               this.Name = "TimKiem_DocGia";
               this.Size = new System.Drawing.Size(1048, 483);
               this.panelBar.ResumeLayout(false);
               this.panelBar.PerformLayout();
               this.ResumeLayout(false);

          }

        #endregion

        private System.Windows.Forms.Panel panelShowKQ;
        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.ComboBox cbbPhanLoai;
        private System.Windows.Forms.TextBox txbTimKiem;
        private System.Windows.Forms.Label lblTheo;
        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.Button btnTimKiem;
    }
}
