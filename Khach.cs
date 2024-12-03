using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyThuePhongNhaNghi
{
    public partial class Khach : Form
    {
        private readonly string connectionString = "Server=(LocalDB)\\MSSQLLocalDB; Database=QLThuePhong;Integrated Security=True";
        public SqlConnection conn;
        public void openConnect()
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
        }
        public void closeConnect()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        private void LoadKhach()
        {
            try
            {
                openConnect();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Khach", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                khachDataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
            finally
            {
                closeConnect();
            }
        }
        public Khach()
        {
            InitializeComponent();
            LoadKhach();
            cbgtk.Items.Add("Nam");
            cbgtk.Items.Add("Nữ");
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string cmnd = txtcccd.Text;

            if (string.IsNullOrEmpty(cmnd))
            {
                MessageBox.Show("Vui lòng nhập số CMND để xóa.");
                return;
            }
            try
            {
                openConnect();
                string query = "DELETE FROM Khach WHERE CMT = @CMT"; 
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CMT", cmnd);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa khách hàng thành công.");
                        LoadKhach();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khách hàng với số CMND đã nhập.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message);
            }
            finally
            {
                closeConnect();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string cmnd = txtcccd.Text;
            string hoTen = txttenk.Text;
            string diaChi = txtdiachik.Text;
            string gioiTinh = cbgtk.SelectedItem?.ToString();
            string sdt = txtdtk.Text;

            if (string.IsNullOrEmpty(cmnd) || string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }
            try
            {
                openConnect();
                string query = "INSERT INTO Khach (CMT, HoTen, DiaChi, GT, SDT) VALUES (@CMT, @HoTen, @DiaChi, @GT, @SDT)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CMT", cmnd);
                    cmd.Parameters.AddWithValue("@HoTen", hoTen);
                    cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                    cmd.Parameters.AddWithValue("@GT", gioiTinh);
                    cmd.Parameters.AddWithValue("@SDT", sdt);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Thêm khách hàng thành công.");
                LoadKhach();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message);
            }
            finally
            {
                closeConnect();
            }
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            string cmnd = txtcccd.Text;
            string hoTen = txttenk.Text;
            string diaChi = txtdiachik.Text;
            string gioiTinh = cbgtk.SelectedItem?.ToString(); 
            string sdt = txtdtk.Text;

            if (string.IsNullOrEmpty(cmnd) || string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }
            try
            {
                openConnect();
                string query = "UPDATE Khach SET HoTen = @HoTen, DiaChi = @DiaChi, GT = @GT, SDT = @SDT WHERE CMT = @CMT"; 
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@HoTen", hoTen);
                    cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                    cmd.Parameters.AddWithValue("@GT", gioiTinh);
                    cmd.Parameters.AddWithValue("@SDT", sdt);
                    cmd.Parameters.AddWithValue("@CMT", cmnd); 
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật khách hàng thành công.");
                        LoadKhach();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khách hàng với số CMND đã nhập.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa dữ liệu: " + ex.Message);
            }
            finally
            {
                closeConnect();
            }
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
        private void Khach_Load(object sender, EventArgs e)
        {
        }

        private void khachDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && khachDataGridView.Rows[e.RowIndex].Cells["CMT"].Value != null)
            {
                DataGridViewRow row = khachDataGridView.Rows[e.RowIndex];
                txtcccd.Text = row.Cells["CMT"].Value.ToString();
                txttenk.Text = row.Cells["HoTen"].Value.ToString();
                txtdiachik.Text = row.Cells["DiaChi"].Value.ToString();
                txtdtk.Text = row.Cells["SDT"].Value.ToString();
                cbgtk.SelectedItem = row.Cells["GT"].Value?.ToString() ?? string.Empty;
            }
        }
    }
}