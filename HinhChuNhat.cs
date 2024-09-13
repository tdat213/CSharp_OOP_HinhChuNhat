using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_HinhChuNhat
{
    internal class HinhChuNhat
    {
        public int cDai;
        public int cRong;

        public void setcDai(int cDai)
        {
            this.cDai = cDai;
        }
        public int getcDai()
        {
            return this.cDai;
        }

        public void setcRong(int cRong)
        {
            this.cRong = cRong;
        }
        public int getcRong()
        {
            return this.cRong;
        }
    }
}
