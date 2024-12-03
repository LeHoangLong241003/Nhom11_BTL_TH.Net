using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuePhongNhaNghi
{
    public partial class Login : Form
    {
        private string connectionString = "Server=(LocalDB)\\MSSQLLocalDB;Database=QLThuePhong;Integrated Security=True";
        public Login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string taikhoan = txttaikhoan.Text;
            string matkhau = txtmatkhau.Text;

            if (string.IsNullOrWhiteSpace(taikhoan))
            {
                MessageBox.Show("Bạn phải nhập username vào!", "Đăng nhập");
                txttaikhoan.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(matkhau))
            {
                MessageBox.Show("Bạn phải nhập Password vào!", "Đăng nhập");
                txtmatkhau.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM TaiKhoan WHERE TaiKhoan = @TaiKhoan AND MatKhau = @MatKhau";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@TaiKhoan", taikhoan);
                        cmd.Parameters.AddWithValue("@MatKhau", matkhau);

                        using (SqlDataReader read = cmd.ExecuteReader())
                        {
                            if (read.Read())
                            {
                                MessageBox.Show("Bạn đăng nhập thành công!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                TrangChu trangchu = new TrangChu();
                                this.Hide();
                                trangchu.ShowDialog();
                                this.Show();
                            }
                            else
                            {
                                MessageBox.Show("Tài khoản chưa có, hoặc bạn nhập sai Username hoặc Password", "Đăng nhập");
                                txttaikhoan.Clear();
                                txtmatkhau.Clear();
                                txttaikhoan.Focus();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbhienan_CheckedChanged(object sender, EventArgs e)
        {
            txtmatkhau.UseSystemPasswordChar = !cbhienan.Checked;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
