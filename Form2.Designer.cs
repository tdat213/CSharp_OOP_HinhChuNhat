namespace CSharp_OOP_HinhChuNhat
{
    partial class Form2
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
            btnNhap = new Button();
            label1 = new Label();
            txtHoTen = new TextBox();
            lb = new Label();
            txtMSSV = new TextBox();
            label3 = new Label();
            txtNgaySinh = new TextBox();
            label4 = new Label();
            txtSDT = new TextBox();
            label5 = new Label();
            txtGioiTinh = new TextBox();
            SuspendLayout();
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(128, 325);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(125, 23);
            btnNhap.TabIndex = 0;
            btnNhap.Text = "Nhap Thong Tin";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 88);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "Ho Ten";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(180, 87);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(100, 23);
            txtHoTen.TabIndex = 2;
            // 
            // lb
            // 
            lb.AutoSize = true;
            lb.Location = new Point(99, 129);
            lb.Name = "lb";
            lb.Size = new Size(37, 15);
            lb.TabIndex = 1;
            lb.Text = "MSSV";
            // 
            // txtMSSV
            // 
            txtMSSV.Location = new Point(180, 128);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(100, 23);
            txtMSSV.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 177);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 1;
            label3.Text = "Ngay Sinh";
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Location = new Point(180, 176);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(100, 23);
            txtNgaySinh.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(99, 229);
            label4.Name = "label4";
            label4.Size = new Size(26, 15);
            label4.TabIndex = 1;
            label4.Text = "SDT";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(180, 228);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(100, 23);
            txtSDT.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(99, 272);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 1;
            label5.Text = "Gioi Tinh";
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.Location = new Point(180, 271);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(100, 23);
            txtGioiTinh.TabIndex = 2;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtGioiTinh);
            Controls.Add(label5);
            Controls.Add(txtSDT);
            Controls.Add(label4);
            Controls.Add(txtNgaySinh);
            Controls.Add(label3);
            Controls.Add(txtMSSV);
            Controls.Add(lb);
            Controls.Add(txtHoTen);
            Controls.Add(label1);
            Controls.Add(btnNhap);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNhap;
        private Label label1;
        private TextBox txtHoTen;
        private Label lb;
        private TextBox txtMSSV;
        private Label label3;
        private TextBox txtNgaySinh;
        private Label label4;
        private TextBox txtSDT;
        private Label label5;
        private TextBox txtGioiTinh;
    }
}