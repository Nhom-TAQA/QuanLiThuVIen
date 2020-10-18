namespace QL_TV
{
     partial class QuanLy
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
               this.btnTatCa = new System.Windows.Forms.Button();
               this.panelData = new System.Windows.Forms.Panel();
               this.panelBar.SuspendLayout();
               this.SuspendLayout();
               // 
               // panelBar
               // 
               this.panelBar.Controls.Add(this.btnThemMoi);
               this.panelBar.Controls.Add(this.btnTimKiem);
               this.panelBar.Controls.Add(this.btnTatCa);
               this.panelBar.Dock = System.Windows.Forms.DockStyle.Top;
               this.panelBar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.panelBar.Location = new System.Drawing.Point(0, 0);
               this.panelBar.Margin = new System.Windows.Forms.Padding(4);
               this.panelBar.Name = "panelBar";
               this.panelBar.Size = new System.Drawing.Size(1048, 40);
               this.panelBar.TabIndex = 2;
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
               this.btnThemMoi.Margin = new System.Windows.Forms.Padding(2);
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
               this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
               this.btnTimKiem.Name = "btnTimKiem";
               this.btnTimKiem.Size = new System.Drawing.Size(138, 40);
               this.btnTimKiem.TabIndex = 3;
               this.btnTimKiem.Text = "Tìm kiếm";
               this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
               this.btnTimKiem.UseVisualStyleBackColor = true;
               this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click_1);
               // 
               // btnTatCa
               // 
               this.btnTatCa.Dock = System.Windows.Forms.DockStyle.Left;
               this.btnTatCa.FlatAppearance.BorderSize = 0;
               this.btnTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnTatCa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnTatCa.ForeColor = System.Drawing.Color.ForestGreen;
               this.btnTatCa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
               this.btnTatCa.Location = new System.Drawing.Point(0, 0);
               this.btnTatCa.Margin = new System.Windows.Forms.Padding(2);
               this.btnTatCa.Name = "btnTatCa";
               this.btnTatCa.Size = new System.Drawing.Size(138, 40);
               this.btnTatCa.TabIndex = 2;
               this.btnTatCa.Text = "Tất cả";
               this.btnTatCa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
               this.btnTatCa.UseVisualStyleBackColor = true;
               this.btnTatCa.Click += new System.EventHandler(this.btnTatCa_Click_1);
               // 
               // panelData
               // 
               this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
               this.panelData.Location = new System.Drawing.Point(0, 40);
               this.panelData.Name = "panelData";
               this.panelData.Size = new System.Drawing.Size(1048, 445);
               this.panelData.TabIndex = 3;
               // 
               // QuanLy
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.LightYellow;
               this.Controls.Add(this.panelData);
               this.Controls.Add(this.panelBar);
               this.Name = "QuanLy";
               this.Size = new System.Drawing.Size(1048, 485);
               this.panelBar.ResumeLayout(false);
               this.ResumeLayout(false);

          }

        #endregion

        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnTatCa;
        private System.Windows.Forms.Panel panelData;
    }
}
