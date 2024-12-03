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
    public partial class DichVu : Form
    {
        private readonly string connectionString = "Server=(LocalDB)\\MSSQLLocalDB; Database=QLThuePhong;Integrated Security=True";
        public SqlConnection conn;
        public DichVu()
        {
            InitializeComponent();
            LoadDichVu();
        }
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

        private void LoadDichVu()
        {
            try
            {
                openConnect();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM DichVu", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dichvuDataGridView.DataSource = dt; 
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
        private void DichVu_Load(object sender, EventArgs e)
        {

        }

        private void btnthemdv_Click(object sender, EventArgs e)
        {
            string maDV = txtmadv.Text.Trim();
            string tenDV = txttendv.Text.Trim();
            string giaDV = txt_gia.Text.Trim();
            string donViTinh = txtdvt.Text.Trim();

            if (string.IsNullOrEmpty(maDV) || string.IsNullOrEmpty(tenDV) || string.IsNullOrEmpty(giaDV) || string.IsNullOrEmpty(donViTinh))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin dịch vụ.");
                return;
            }

            try
            {
                openConnect();
                string query = "INSERT INTO DichVu (MaDV, TenDV, GiaDV, DVT) VALUES (@MaDV, @TenDV, @GiaDV, @DVT)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaDV", maDV);
                    cmd.Parameters.AddWithValue("@TenDV", tenDV);
                    cmd.Parameters.AddWithValue("@GiaDV", decimal.Parse(giaDV));
                    cmd.Parameters.AddWithValue("@DVT", donViTinh);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Thêm dịch vụ thành công.");
                LoadDichVu();
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

        private void btnsuadv_Click(object sender, EventArgs e)
        {
            string maDV = txtmadv.Text.Trim();
            string tenDV = txttendv.Text.Trim();
            string giaDV = txt_gia.Text.Trim();
            string donViTinh = txtdvt.Text.Trim();

            if (string.IsNullOrEmpty(maDV) || string.IsNullOrEmpty(tenDV) || string.IsNullOrEmpty(giaDV) || string.IsNullOrEmpty(donViTinh))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin dịch vụ.");
                return;
            }

            try
            {
                openConnect();
                string query = "UPDATE DichVu SET TenDV = @TenDV, GiaDV = @GiaDV, DVT = @DVT WHERE MaDV = @MaDV";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaDV", maDV);
                    cmd.Parameters.AddWithValue("@TenDV", tenDV);
                    cmd.Parameters.AddWithValue("@GiaDV", decimal.Parse(giaDV));
                    cmd.Parameters.AddWithValue("@DVT", donViTinh);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Sửa dịch vụ thành công.");
                        LoadDichVu();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dịch vụ với mã đã nhập.");
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

        private void btnxoadv_Click(object sender, EventArgs e)
        {
            string maDV = txtmadv.Text.Trim();

            if (string.IsNullOrEmpty(maDV))
            {
                MessageBox.Show("Vui lòng nhập mã dịch vụ để xóa.");
                return;
            }

            try
            {
                openConnect();
                string query = "DELETE FROM DichVu WHERE MaDV = @MaDV";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaDV", maDV);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa dịch vụ thành công.");
                        LoadDichVu();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dịch vụ với mã đã nhập.");
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

        private void btnthoatdv_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
