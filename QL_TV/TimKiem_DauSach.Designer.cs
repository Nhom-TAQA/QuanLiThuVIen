namespace QL_TV
{
     partial class TimKiem_DauSach
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
               this.panelBar = new System.Windows.Forms.Panel();
               this.cbbPhanLoai = new System.Windows.Forms.ComboBox();
               this.txbTimKiem = new System.Windows.Forms.TextBox();
               this.lblTheo = new System.Windows.Forms.Label();
               this.lblNoiDung = new System.Windows.Forms.Label();
               this.button1 = new System.Windows.Forms.Button();
               this.panelShowKQ = new System.Windows.Forms.Panel();
               this.panelBar.SuspendLayout();
               this.SuspendLayout();
               // 
               // panelBar
               // 
               this.panelBar.Controls.Add(this.cbbPhanLoai);
               this.panelBar.Controls.Add(this.txbTimKiem);
               this.panelBar.Controls.Add(this.lblTheo);
               this.panelBar.Controls.Add(this.lblNoiDung);
               this.panelBar.Controls.Add(this.button1);
               this.panelBar.Dock = System.Windows.Forms.DockStyle.Top;
               this.panelBar.Location = new System.Drawing.Point(0, 0);
               this.panelBar.Name = "panelBar";
               this.panelBar.Size = new System.Drawing.Size(1050, 60);
               this.panelBar.TabIndex = 0;
               // 
               // cbbPhanLoai
               // 
               this.cbbPhanLoai.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.cbbPhanLoai.FormattingEnabled = true;
               this.cbbPhanLoai.Items.AddRange(new object[] {
            "Mã Đầu Sách",
            "Tên Đầu Sách",
            "Tác Giả"});
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
               // button1
               // 
               this.button1.BackColor = System.Drawing.Color.ForestGreen;
               this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button1.ForeColor = System.Drawing.Color.White;
               this.button1.Location = new System.Drawing.Point(918, 13);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(113, 37);
               this.button1.TabIndex = 0;
               this.button1.Text = "Tìm kiếm";
               this.button1.UseVisualStyleBackColor = false;
               this.button1.Click += new System.EventHandler(this.button1_Click);
               // 
               // panelShowKQ
               // 
               this.panelShowKQ.Dock = System.Windows.Forms.DockStyle.Fill;
               this.panelShowKQ.Location = new System.Drawing.Point(0, 60);
               this.panelShowKQ.Name = "panelShowKQ";
               this.panelShowKQ.Size = new System.Drawing.Size(1050, 425);
               this.panelShowKQ.TabIndex = 1;
               // 
               // TimKiem_DauSach
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
               this.Name = "TimKiem_DauSach";
               this.Size = new System.Drawing.Size(1050, 485);
               this.panelBar.ResumeLayout(false);
               this.panelBar.PerformLayout();
               this.ResumeLayout(false);

          }

        #endregion

        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Label lblTheo;
        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelShowKQ;
        private System.Windows.Forms.ComboBox cbbPhanLoai;
        private System.Windows.Forms.TextBox txbTimKiem;
    }
}
