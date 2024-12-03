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
    public partial class TimKiem : Form
    {
        public TimKiem()
        {
            InitializeComponent();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
           TimKiemKH timKiemKH = new TimKiemKH();
           timKiemKH.Show();
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimKiemP timKiemP = new TimKiemP();
            timKiemP.Show();
        }
    }
}
