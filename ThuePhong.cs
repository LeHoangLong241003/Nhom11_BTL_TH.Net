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
    public partial class ThuePhong : Form
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
        private void LoadThuePhong()
        {
            try
            {
                openConnect();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM ThueP", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                thuePDataGridView.DataSource = dt;
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
        private void LoadPhong()
        {
            try
            {
                openConnect();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Phong", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                phongDataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu" + ex.Message);
            }
            finally
            {
                closeConnect();
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
        private void LoadRoomTypes()
        {
            var roomTypes = new[] {
                "",
                "Đơn thường",
                "Đôi thường",
                "Ba thường",
                "VIP đơn",
                "VIP đôi",
                "VIP ba"
            };

            cbb_loaip.DataSource = roomTypes;
        }
        private void LoadPhongByType(string roomType)
        {
            try
            {
                openConnect();
                string query = "SELECT * FROM Phong WHERE LoaiP = @LoaiP";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@LoaiP", roomType);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                phongDataGridView.DataSource = dt;
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
        private bool IsPhongAvailable(string maPhong)
        {
            try
            {
                openConnect();
                string query = "SELECT Tinhtrang FROM Phong WHERE MaP = @MaP";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaP", maPhong);
                string tinhTrang = cmd.ExecuteScalar()?.ToString();
                return tinhTrang == "Trống";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra trạng thái phòng: " + ex.Message);
                return false;
            }
            finally
            {
                closeConnect();
            }
        }
        private void UpdatePhongStatus(string maPhong, string tinhTrang)
        {
            try
            {
                openConnect();
                string query = "UPDATE Phong SET Tinhtrang = @Tinhtrang WHERE MaP = @MaP";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Tinhtrang", tinhTrang);
                cmd.Parameters.AddWithValue("@MaP", maPhong);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật trạng thái phòng: " + ex.Message);
            }
            finally
            {
                closeConnect();
            }
        }

        public ThuePhong()
        {
            InitializeComponent();
            LoadThuePhong();
            LoadKhach();
            LoadPhong();
            LoadRoomTypes();
        }

        private void ThuePhong_Load(object sender, EventArgs e)
        {

        }

        private void btnthemk_Click(object sender, EventArgs e)
        {
           Khach khach = new Khach();
           khach.Show();
        }

        private void khachDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnthuep_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedCMT) || string.IsNullOrEmpty(selectedMaPhong))
            {
                MessageBox.Show("Vui lòng chọn khách hàng và phòng.");
                return;
            }

            if (!IsPhongAvailable(selectedMaPhong))
            {
                MessageBox.Show("Phòng này hiện đang được thuê.");
                return;
            }

            string nhanVienPT = txt_tennv.Text; 
            DateTime ngayDen = DateTime.Now; 

            try
            {
                openConnect();
                string query = "INSERT INTO ThueP (CMT, MaP, Ngayden, TenNV) VALUES (@CMT, @MaP, @Ngayden, @TenNV)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CMT", selectedCMT);
                cmd.Parameters.AddWithValue("@MaP", selectedMaPhong);
                cmd.Parameters.AddWithValue("@Ngayden", ngayDen);
                cmd.Parameters.AddWithValue("@TenNV", nhanVienPT);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Thuê phòng thành công!");
                    UpdatePhongStatus(selectedMaPhong, "Có khách");
                    LoadThuePhong();
                }
                else
                {
                    MessageBox.Show("Thuê phòng thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thuê phòng: " + ex.Message);
            }
            finally
            {
                closeConnect();
            }
        }

        private void phongDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private bool IsCMTInDanhSachThuePhong(string cmt)
        {
            try
            {
                openConnect();
                string query = "SELECT COUNT(*) FROM ThueP WHERE CMT = @CMT";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CMT", cmt);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra CMT trong danh sách thuê phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                closeConnect();
            }
        }
        private bool IsCMTInDanhSachKhach(string cmt)
        {
            try
            {
                openConnect();
                string query = "SELECT COUNT(*) FROM Khach WHERE CMT = @CMT";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CMT", cmt);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra CMT trong danh sách khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                closeConnect();
            }
        }

        private string selectedCMT = "";
        private void btnchonk_Click(object sender, EventArgs e)
        {

            if (khachDataGridView.SelectedRows.Count > 0)
            {
                string cmt = khachDataGridView.SelectedRows[0].Cells["CMT"].Value.ToString();
                if (IsCMTInDanhSachThuePhong(cmt))
                {
                    MessageBox.Show("CMT đã tồn tại trong danh sách thuê phòng. Vui lòng chọn khách hàng khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!IsCMTInDanhSachKhach(cmt))
                {
                    MessageBox.Show("CMT không tồn tại trong danh sách khách hàng. Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                selectedCMT = cmt;
                MessageBox.Show("Đã chọn khách hàng: " + selectedCMT, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private string selectedMaPhong = "";
        private void btnchonp_Click(object sender, EventArgs e)
        {
            if (phongDataGridView.SelectedRows.Count > 0)
            {
                string tinhTrang = phongDataGridView.SelectedRows[0].Cells["Tinhtrang"].Value.ToString();
                if (tinhTrang == "Trống")
                {
                    selectedMaPhong = phongDataGridView.SelectedRows[0].Cells["MaP"].Value.ToString();
                    MessageBox.Show("Đã chọn phòng: " + selectedMaPhong);
                }
                else
                {
                    MessageBox.Show("Phòng này đã có khách. Vui lòng chọn phòng khác.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phòng.");
            }
        }

        private void cbb_loaip_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = cbb_loaip.SelectedItem.ToString();

            if (string.IsNullOrEmpty(selectedType))
            {
                LoadPhong();
            }
            else
            {
                LoadPhongByType(selectedType);
            }
        }

    }
}
