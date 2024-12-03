using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuePhongNhaNghi
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void btnphong_Click(object sender, EventArgs e)
        {
            Phong phong = new Phong();
            phong.Show();
        }

        private void btnthuephong_Click(object sender, EventArgs e)
        {
            ThuePhong thuePhong = new ThuePhong();
            thuePhong.Show();
        }

        private void btnkhach_Click(object sender, EventArgs e)
        {
            Khach khach = new Khach();
            khach.Show();
        }

        private void btndichvu_Click(object sender, EventArgs e)
        {
            SuDungDV suDungDV = new SuDungDV();
            suDungDV.Show();
        }

        private void btntaikhoan_Click(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = new TaiKhoan();
            taiKhoan.Show();
        }
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            TimKiem timKiem = new TimKiem();
            timKiem.Show();
        }

        private void btntraphong_Click(object sender, EventArgs e)
        {
            TraPhong trtraphong = new TraPhong();
            trtraphong.Show();
        }
    }
}
