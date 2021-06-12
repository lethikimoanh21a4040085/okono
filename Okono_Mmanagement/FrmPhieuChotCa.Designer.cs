namespace Okono
{
    partial class FrmPhieuChotCa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPhieuChotCa));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbThoiGian = new System.Windows.Forms.TextBox();
            this.tbTenNhanVien = new System.Windows.Forms.TextBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.cbMaNhanVien = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gridViewChenhLech = new System.Windows.Forms.DataGridView();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.tbTienThucTe = new System.Windows.Forms.TextBox();
            this.cbCaLamViec = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewChenhLech)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(513, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHIẾU CHỐT CA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(640, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label3.Location = new System.Drawing.Point(141, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã nhân viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label4.Location = new System.Drawing.Point(136, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên nhân viên:";
            // 
            // tbThoiGian
            // 
            this.tbThoiGian.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.tbThoiGian.Location = new System.Drawing.Point(697, 182);
            this.tbThoiGian.Name = "tbThoiGian";
            this.tbThoiGian.Size = new System.Drawing.Size(226, 28);
            this.tbThoiGian.TabIndex = 14;
            // 
            // tbTenNhanVien
            // 
            this.tbTenNhanVien.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.tbTenNhanVien.Location = new System.Drawing.Point(285, 340);
            this.tbTenNhanVien.Name = "tbTenNhanVien";
            this.tbTenNhanVien.Size = new System.Drawing.Size(226, 28);
            this.tbTenNhanVien.TabIndex = 14;
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIn.Location = new System.Drawing.Point(416, 630);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(95, 40);
            this.btnIn.TabIndex = 30;
            this.btnIn.Text = "  In";
            this.btnIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // cbMaNhanVien
            // 
            this.cbMaNhanVien.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.cbMaNhanVien.FormattingEnabled = true;
            this.cbMaNhanVien.Location = new System.Drawing.Point(285, 275);
            this.cbMaNhanVien.Name = "cbMaNhanVien";
            this.cbMaNhanVien.Size = new System.Drawing.Size(226, 28);
            this.cbMaNhanVien.TabIndex = 24;
            this.cbMaNhanVien.SelectedIndexChanged += new System.EventHandler(this.cbMaNhanVien_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.label7.Location = new System.Drawing.Point(693, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Thực thu:";
            // 
            // gridViewChenhLech
            // 
            this.gridViewChenhLech.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewChenhLech.Location = new System.Drawing.Point(140, 402);
            this.gridViewChenhLech.Name = "gridViewChenhLech";
            this.gridViewChenhLech.RowHeadersWidth = 51;
            this.gridViewChenhLech.Size = new System.Drawing.Size(963, 188);
            this.gridViewChenhLech.TabIndex = 32;
            this.gridViewChenhLech.Text = "dataGridView1";
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.Location = new System.Drawing.Point(715, 630);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(95, 40);
            this.btnHuy.TabIndex = 33;
            this.btnHuy.Text = "  Huỷ";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.Location = new System.Drawing.Point(1008, 630);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 40);
            this.btnThoat.TabIndex = 34;
            this.btnThoat.Text = " Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.ForeColor = System.Drawing.Color.Red;
            this.btnXem.Image = global::Okono_Mmanagement.Properties.Resources.Background__1_1;
            this.btnXem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXem.Location = new System.Drawing.Point(140, 630);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(95, 40);
            this.btnXem.TabIndex = 44;
            this.btnXem.Text = "  Xem";
            this.btnXem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // tbTienThucTe
            // 
            this.tbTienThucTe.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.tbTienThucTe.Location = new System.Drawing.Point(779, 340);
            this.tbTienThucTe.Name = "tbTienThucTe";
            this.tbTienThucTe.Size = new System.Drawing.Size(250, 28);
            this.tbTienThucTe.TabIndex = 45;
            // 
            // cbCaLamViec
            // 
            this.cbCaLamViec.FormattingEnabled = true;
            this.cbCaLamViec.Location = new System.Drawing.Point(357, 183);
            this.cbCaLamViec.Name = "cbCaLamViec";
            this.cbCaLamViec.Size = new System.Drawing.Size(250, 27);
            this.cbCaLamViec.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 19);
            this.label5.TabIndex = 47;
            this.label5.Text = "Ca:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1044, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 19);
            this.label6.TabIndex = 48;
            this.label6.Text = "VNĐ";
            // 
            // FrmPhieuChotCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1284, 781);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbCaLamViec);
            this.Controls.Add(this.tbTienThucTe);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.gridViewChenhLech);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbMaNhanVien);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.tbTenNhanVien);
            this.Controls.Add(this.tbThoiGian);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPhieuChotCa";
            this.Text = "Phiếu chốt ca";
            this.Load += new System.EventHandler(this.FrmPhieuChotCa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewChenhLech)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbThoiGian;
        private System.Windows.Forms.TextBox tbTenNhanVien;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.ComboBox cbMaNhanVien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView gridViewChenhLech;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.TextBox tbTienThucTe;
        private System.Windows.Forms.ComboBox cbCaLamViec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}