namespace QL_TV
{
     partial class UserDauSach
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
               this.btnThemMoi = new System.Windows.Forms.Button();
               this.btnTimKiem = new System.Windows.Forms.Button();
               this.btnDauSach = new System.Windows.Forms.Button();
               this.panelData = new System.Windows.Forms.Panel();
               this.panelBar.SuspendLayout();
               this.SuspendLayout();
               // 
               // panelBar
               // 
               this.panelBar.Controls.Add(this.btnThemMoi);
               this.panelBar.Controls.Add(this.btnTimKiem);
               this.panelBar.Controls.Add(this.btnDauSach);
               this.panelBar.Dock = System.Windows.Forms.DockStyle.Top;
               this.panelBar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.panelBar.Location = new System.Drawing.Point(0, 0);
               this.panelBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.panelBar.Name = "panelBar";
               this.panelBar.Size = new System.Drawing.Size(1050, 40);
               this.panelBar.TabIndex = 1;
               // 
               // btnThemMoi
               // 
               this.btnThemMoi.Dock = System.Windows.Forms.DockStyle.Left;
               this.btnThemMoi.FlatAppearance.BorderSize = 0;
               this.btnThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnThemMoi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnThemMoi.ForeColor = System.Drawing.Color.ForestGreen;
               this.btnThemMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
               this.btnThemMoi.Location = new System.Drawing.Point(276, 0);
               this.btnThemMoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.btnThemMoi.Name = "btnThemMoi";
               this.btnThemMoi.Size = new System.Drawing.Size(138, 40);
               this.btnThemMoi.TabIndex = 5;
               this.btnThemMoi.Text = "Thêm mới";
               this.btnThemMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
               this.btnThemMoi.UseVisualStyleBackColor = true;
               this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
               // 
               // btnTimKiem
               // 
               this.btnTimKiem.Dock = System.Windows.Forms.DockStyle.Left;
               this.btnTimKiem.FlatAppearance.BorderSize = 0;
               this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnTimKiem.ForeColor = System.Drawing.Color.ForestGreen;
               this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
               this.btnTimKiem.Location = new System.Drawing.Point(138, 0);
               this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.btnTimKiem.Name = "btnTimKiem";
               this.btnTimKiem.Size = new System.Drawing.Size(138, 40);
               this.btnTimKiem.TabIndex = 3;
               this.btnTimKiem.Text = "Tìm kiếm";
               this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
               this.btnTimKiem.UseVisualStyleBackColor = true;
               this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
               // 
               // btnDauSach
               // 
               this.btnDauSach.Dock = System.Windows.Forms.DockStyle.Left;
               this.btnDauSach.FlatAppearance.BorderSize = 0;
               this.btnDauSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnDauSach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnDauSach.ForeColor = System.Drawing.Color.ForestGreen;
               this.btnDauSach.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
               this.btnDauSach.Location = new System.Drawing.Point(0, 0);
               this.btnDauSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.btnDauSach.Name = "btnDauSach";
               this.btnDauSach.Size = new System.Drawing.Size(138, 40);
               this.btnDauSach.TabIndex = 2;
               this.btnDauSach.Text = "Tất cả";
               this.btnDauSach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
               this.btnDauSach.UseVisualStyleBackColor = true;
               this.btnDauSach.Click += new System.EventHandler(this.btnDauSach_Click);
               // 
               // panelData
               // 
               this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
               this.panelData.Location = new System.Drawing.Point(0, 40);
               this.panelData.Name = "panelData";
               this.panelData.Size = new System.Drawing.Size(1050, 485);
               this.panelData.TabIndex = 2;
               // 
               // Sach
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.LightYellow;
               this.Controls.Add(this.panelData);
               this.Controls.Add(this.panelBar);
               this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.Name = "Sach";
               this.Size = new System.Drawing.Size(1050, 525);
               this.panelBar.ResumeLayout(false);
               this.ResumeLayout(false);

          }

        #endregion

        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Button btnDauSach;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnTimKiem;
          private System.Windows.Forms.Panel panelData;
     }
}
