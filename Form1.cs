namespace CSharp_OOP_HinhChuNhat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            HinhChuNhat hinhChuNhat = new HinhChuNhat();
            hinhChuNhat.setcDai(int.Parse(txtcDai.Text));
            hinhChuNhat.setcRong(int.Parse(txtcRong.Text));

            MessageBox.Show("Chieu dai: "+ hinhChuNhat.getcDai() + "\nChieu rong: "+ hinhChuNhat.getcRong());
        }

        
    }
}
