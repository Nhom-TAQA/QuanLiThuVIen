namespace QL_TV
{
     partial class DangNhap
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
               this.panel1 = new System.Windows.Forms.Panel();
               this.checkBoxShowPass = new System.Windows.Forms.CheckBox();
               this.llbTaoMoi = new System.Windows.Forms.LinkLabel();
               this.btnDangNhap = new System.Windows.Forms.Button();
               this.lblPass = new System.Windows.Forms.Label();
               this.lblName = new System.Windows.Forms.Label();
               this.txbTenDangNhap = new System.Windows.Forms.TextBox();
               this.txbMatKhau = new System.Windows.Forms.TextBox();
               this.label1 = new System.Windows.Forms.Label();
               this.btnExit = new System.Windows.Forms.Button();
               this.panel1.SuspendLayout();
               this.SuspendLayout();
               // 
               // panel1
               // 
               this.panel1.BackColor = System.Drawing.Color.LightYellow;
               this.panel1.Controls.Add(this.checkBoxShowPass);
               this.panel1.Controls.Add(this.llbTaoMoi);
               this.panel1.Controls.Add(this.btnDangNhap);
               this.panel1.Controls.Add(this.lblPass);
               this.panel1.Controls.Add(this.lblName);
               this.panel1.Controls.Add(this.txbTenDangNhap);
               this.panel1.Controls.Add(this.txbMatKhau);
               this.panel1.Location = new System.Drawing.Point(12, 12);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(294, 348);
               this.panel1.TabIndex = 0;
               // 
               // checkBoxShowPass
               // 
               this.checkBoxShowPass.AutoSize = true;
               this.checkBoxShowPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.checkBoxShowPass.Location = new System.Drawing.Point(34, 194);
               this.checkBoxShowPass.Name = "checkBoxShowPass";
               this.checkBoxShowPass.Size = new System.Drawing.Size(169, 26);
               this.checkBoxShowPass.TabIndex = 8;
               this.checkBoxShowPass.Text = "Hiển thị mật khẩu";
               this.checkBoxShowPass.UseVisualStyleBackColor = true;
               this.checkBoxShowPass.CheckedChanged += new System.EventHandler(this.checkBoxShowPass_CheckedChanged);
               // 
               // llbTaoMoi
               // 
               this.llbTaoMoi.AutoSize = true;
               this.llbTaoMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.llbTaoMoi.ForeColor = System.Drawing.Color.ForestGreen;
               this.llbTaoMoi.LinkColor = System.Drawing.Color.DarkCyan;
               this.llbTaoMoi.Location = new System.Drawing.Point(71, 232);
               this.llbTaoMoi.Name = "llbTaoMoi";
               this.llbTaoMoi.Size = new System.Drawing.Size(153, 22);
               this.llbTaoMoi.TabIndex = 7;
               this.llbTaoMoi.TabStop = true;
               this.llbTaoMoi.Text = "Tạo tài khoản mới";
               // 
               // btnDangNhap
               // 
               this.btnDangNhap.BackColor = System.Drawing.Color.ForestGreen;
               this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnDangNhap.ForeColor = System.Drawing.Color.White;
               this.btnDangNhap.Location = new System.Drawing.Point(61, 283);
               this.btnDangNhap.Name = "btnDangNhap";
               this.btnDangNhap.Size = new System.Drawing.Size(172, 43);
               this.btnDangNhap.TabIndex = 2;
               this.btnDangNhap.Text = "Đăng nhập";
               this.btnDangNhap.UseVisualStyleBackColor = false;
               this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
               // 
               // lblPass
               // 
               this.lblPass.AutoSize = true;
               this.lblPass.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.lblPass.ForeColor = System.Drawing.Color.ForestGreen;
               this.lblPass.Location = new System.Drawing.Point(20, 116);
               this.lblPass.Name = "lblPass";
               this.lblPass.Size = new System.Drawing.Size(104, 27);
               this.lblPass.TabIndex = 3;
               this.lblPass.Text = "Mật khẩu";
               // 
               // lblName
               // 
               this.lblName.AutoSize = true;
               this.lblName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.lblName.ForeColor = System.Drawing.Color.ForestGreen;
               this.lblName.Location = new System.Drawing.Point(20, 33);
               this.lblName.Name = "lblName";
               this.lblName.Size = new System.Drawing.Size(154, 27);
               this.lblName.TabIndex = 2;
               this.lblName.Text = "Tên đăng nhập";
               // 
               // txbTenDangNhap
               // 
               this.txbTenDangNhap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txbTenDangNhap.Location = new System.Drawing.Point(25, 71);
               this.txbTenDangNhap.Name = "txbTenDangNhap";
               this.txbTenDangNhap.Size = new System.Drawing.Size(228, 34);
               this.txbTenDangNhap.TabIndex = 0;
               // 
               // txbMatKhau
               // 
               this.txbMatKhau.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txbMatKhau.Location = new System.Drawing.Point(25, 154);
               this.txbMatKhau.Name = "txbMatKhau";
               this.txbMatKhau.Size = new System.Drawing.Size(228, 34);
               this.txbMatKhau.TabIndex = 1;
               // 
               // label1
               // 
               this.label1.AllowDrop = true;
               this.label1.AutoEllipsis = true;
               this.label1.BackColor = System.Drawing.Color.Transparent;
               this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.ForeColor = System.Drawing.Color.ForestGreen;
               this.label1.Location = new System.Drawing.Point(312, 12);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(366, 87);
               this.label1.TabIndex = 1;
               this.label1.Text = "THƯ VIỆN HỌC VIỆN KỸ THUẬT QUÂN SỰ";
               this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // 
               // btnExit
               // 
               this.btnExit.BackColor = System.Drawing.Color.OrangeRed;
               this.btnExit.FlatAppearance.BorderSize = 0;
               this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnExit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnExit.ForeColor = System.Drawing.Color.White;
               this.btnExit.Location = new System.Drawing.Point(434, 317);
               this.btnExit.Name = "btnExit";
               this.btnExit.Size = new System.Drawing.Size(120, 43);
               this.btnExit.TabIndex = 5;
               this.btnExit.Text = "Thoát";
               this.btnExit.UseVisualStyleBackColor = false;
               this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
               // 
               // DangNhap
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.LightYellow;
               this.BackgroundImage = global::QL_TV.Properties.Resources.pVsVVFwW3ate4LMDfRzV66xXj5W5TtUZ;
               this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.ClientSize = new System.Drawing.Size(678, 372);
               this.Controls.Add(this.btnExit);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.panel1);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "DangNhap";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "DangNhap";
               this.panel1.ResumeLayout(false);
               this.panel1.PerformLayout();
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.Panel panel1;
          private System.Windows.Forms.CheckBox checkBoxShowPass;
          private System.Windows.Forms.LinkLabel llbTaoMoi;
          private System.Windows.Forms.Button btnDangNhap;
          private System.Windows.Forms.Label lblPass;
          private System.Windows.Forms.Label lblName;
          private System.Windows.Forms.TextBox txbTenDangNhap;
          private System.Windows.Forms.TextBox txbMatKhau;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Button btnExit;
     }
}