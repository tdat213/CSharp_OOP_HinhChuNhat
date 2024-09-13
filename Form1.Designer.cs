namespace CSharp_OOP_HinhChuNhat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNhap = new Button();
            label1 = new Label();
            txtcDai = new TextBox();
            label2 = new Label();
            txtcRong = new TextBox();
            label3 = new Label();
            txtHoTen = new TextBox();
            label4 = new Label();
            txtMSSV = new TextBox();
            label5 = new Label();
            txtNgaySinh = new TextBox();
            label6 = new Label();
            txtSDT = new TextBox();
            label7 = new Label();
            txtGioiTinh = new TextBox();
            btnNhapSV = new Button();
            SuspendLayout();
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(207, 30);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(75, 23);
            btnNhap.TabIndex = 0;
            btnNhap.Text = "Nhap";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 15);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 1;
            label1.Text = "Chieu dai";
            // 
            // txtcDai
            // 
            txtcDai.Location = new Point(101, 12);
            txtcDai.Name = "txtcDai";
            txtcDai.Size = new Size(100, 23);
            txtcDai.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 56);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 1;
            label2.Text = "Chieu rong";
            // 
            // txtcRong
            // 
            txtcRong.Location = new Point(101, 53);
            txtcRong.Name = "txtcRong";
            txtcRong.Size = new Size(100, 23);
            txtcRong.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(354, 18);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 1;
            label3.Text = "Ho ten";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(446, 15);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(100, 23);
            txtHoTen.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(354, 59);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 1;
            label4.Text = "MSSV";
            // 
            // txtMSSV
            // 
            txtMSSV.Location = new Point(446, 56);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(100, 23);
            txtMSSV.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(354, 103);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 1;
            label5.Text = "Ngay sinh";
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Location = new Point(446, 100);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(100, 23);
            txtNgaySinh.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(354, 144);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 1;
            label6.Text = "So dien thoai";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(446, 141);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(100, 23);
            txtSDT.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(354, 187);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 1;
            label7.Text = "Gioi tinh";
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.Location = new Point(446, 184);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(100, 23);
            txtGioiTinh.TabIndex = 2;
            // 
            // btnNhapSV
            // 
            btnNhapSV.Location = new Point(417, 236);
            btnNhapSV.Name = "btnNhapSV";
            btnNhapSV.Size = new Size(75, 23);
            btnNhapSV.TabIndex = 0;
            btnNhapSV.Text = "Nhap";
            btnNhapSV.UseVisualStyleBackColor = true;
            btnNhapSV.Click += btnNhap_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtGioiTinh);
            Controls.Add(txtSDT);
            Controls.Add(label7);
            Controls.Add(txtMSSV);
            Controls.Add(label6);
            Controls.Add(txtcRong);
            Controls.Add(label4);
            Controls.Add(txtNgaySinh);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(txtHoTen);
            Controls.Add(label3);
            Controls.Add(txtcDai);
            Controls.Add(label1);
            Controls.Add(btnNhapSV);
            Controls.Add(btnNhap);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNhap;
        private Label label1;
        private TextBox txtcDai;
        private Label label2;
        private TextBox txtcRong;
        private Label label3;
        private TextBox txtHoTen;
        private Label label4;
        private TextBox txtMSSV;
        private Label label5;
        private TextBox txtNgaySinh;
        private Label label6;
        private TextBox txtSDT;
        private Label label7;
        private TextBox txtGioiTinh;
        private Button btnNhapSV;
    }
}
