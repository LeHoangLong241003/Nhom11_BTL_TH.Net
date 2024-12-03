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
    public partial class TaiKhoan : Form
    {
        public SqlConnection conn;
        public void openConnect()
        {
            conn = new SqlConnection("Server=(LocalDB)\\MSSQLLocalDB; Database=QLThuePhong;Integrated Security=True");
            conn.Open();
        }
        public void closeConnect()
        {
            conn.Close();
        }
        public SqlConnection getConnection()
        {
            return conn;
        }
        private void LoadTaiKoan()
        {
            openConnect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM TaiKhoan", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            taikhoanDataGridView.DataSource = dt;
            closeConnect();
        }
        public TaiKhoan()
        {
            InitializeComponent();
            LoadTaiKoan();
            taikhoanDataGridView.CellClick += taikhoanDataGridView_CellContentClick;
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void btnthemtk_Click(object sender, EventArgs e)
        {
            openConnect();
            SqlCommand cmd = new SqlCommand("INSERT INTO TaiKhoan (TaiKhoan, MatKhau, TenNguoiDung) VALUES (@TaiKhoan, @MatKhau, @TenNguoiDung)", conn);
            cmd.Parameters.AddWithValue("@TaiKhoan", txttk.Text);
            cmd.Parameters.AddWithValue("@MatKhau", txtmk.Text);
            cmd.Parameters.AddWithValue("@TenNguoiDung", txttennd.Text);
            cmd.ExecuteNonQuery();
            closeConnect();
            LoadTaiKoan();
            ClearTaiKhoan();
        }
        private void ClearTaiKhoan()
        {
            txttk.Clear();
            txtmk.Clear();
            txttennd.Clear();
        }

        private void btnsuatk_Click(object sender, EventArgs e)
        {
            openConnect();
            SqlCommand cmd = new SqlCommand("UPDATE TaiKhoan SET MatKhau = @MatKhau, TenNguoiDung = @TenNguoiDung WHERE TaiKhoan = @TaiKhoan", conn);
            cmd.Parameters.AddWithValue("@TaiKhoan", txttk.Text);
            cmd.Parameters.AddWithValue("@MatKhau", txtmk.Text);
            cmd.Parameters.AddWithValue("@TenNguoiDung", txttennd.Text);
            cmd.ExecuteNonQuery();
            closeConnect();
            LoadTaiKoan();
            ClearTaiKhoan();
        }

        private void btnxoatk_Click(object sender, EventArgs e)
        {
            openConnect();
            SqlCommand cmd = new SqlCommand("DELETE FROM TaiKhoan WHERE TaiKhoan = @TaiKhoan", conn);
            cmd.Parameters.AddWithValue("@TaiKhoan", txttk.Text);
            cmd.ExecuteNonQuery();
            closeConnect();
            LoadTaiKoan();
            ClearTaiKhoan();
        }

        private void btnthoattk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void taikhoanDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = taikhoanDataGridView.Rows[e.RowIndex];
                txttk.Text = row.Cells["TaiKhoan"].Value?.ToString() ?? string.Empty;
                txtmk.Text = row.Cells["MatKhau"].Value?.ToString() ?? string.Empty;
                txttennd.Text = row.Cells["TenNguoiDung"].Value?.ToString() ?? string.Empty;
            }
        }
    }
}
