using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_HinhChuNhat
{
    internal class SinhVien
    {
        public string hoTen;
        public int mssv;
        public int ngaySinh;
        public int sdt;
        public string gioiTinh;

        public void sethoTen(string hoTen)
        {
            this.hoTen = hoTen;
        }
        public string gethoTen()
        {
            return this.hoTen;
        }

        public void setmssv(int mssv)
        {
            this.mssv = mssv;
        }
        public int getmssv()
        {
            return this.mssv;
        }

        public void setngaySinh(int ngaySinh)
        {
            this.ngaySinh = ngaySinh;
        }
        public int getngaySinh()
        {
            return this.ngaySinh;
        }

        public void setsdt(int sdt)
        {
            this.sdt = sdt;
        }
        public int getsdt()
        {
            return this.sdt;
        }

        public void setgioiTinh(string gioiTinh)
        {
            this.gioiTinh = gioiTinh;
        }
        public string getgioiTinh()
        {
            return this.gioiTinh;
        }
    }

    
}
