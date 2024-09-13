using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_OOP_HinhChuNhat
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            SinhVien sinhVien = new SinhVien();

            sinhVien.sethoTen(txtHoTen.Text);
            sinhVien.setmssv(int.Parse(txtMSSV.Text));
            sinhVien.setngaySinh(int.Parse(txtNgaySinh.Text));
            sinhVien.setsdt(int.Parse(txtSDT.Text));
            sinhVien.setgioiTinh(txtGioiTinh.Text);

            MessageBox.Show(
                "Ho ten: " + sinhVien.gethoTen() +
                "\nMSSV: " + sinhVien.getmssv() +
                "\nNgay Sinh: " + sinhVien.getngaySinh() +
                "\nSo Dien Thoai: " + sinhVien.getsdt() +
                "\nGioi Tinh: " + sinhVien.getgioiTinh()
            );


        }
    }
}
