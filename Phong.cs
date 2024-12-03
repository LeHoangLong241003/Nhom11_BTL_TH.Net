using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyThuePhongNhaNghi
{
    public partial class Phong : Form
    {
        private readonly string connectionString = "Server=(LocalDB)\\MSSQLLocalDB; Database=QLThuePhong;Integrated Security=True";
        public SqlConnection conn;
        public Phong()
        {
            InitializeComponent();
            LoadPhong();
            LoadRoomTypes(); 
            LoadRoomStatus();
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
        private void LoadPhong()
        {
            try
            {
                openConnect();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Phong", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                danhsachphong.DataSource = dt;
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

            cbloaip.DataSource = roomTypes;
        }
        private void LoadRoomStatus()
        {
            var roomStatuses = new[] {
                "",
                "Trống",
                "Có khách"
            };

            cbtinhtrang.DataSource = roomStatuses;
        }

        private void Phong_Load(object sender, EventArgs e)
        {
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand("INSERT INTO Phong (MaP, TenP, LoaiP, GiaP, Tinhtrang) VALUES (@MaP, @TenP, @LoaiP, @GiaP, @Tinhtrang)", conn);
                cmd.Parameters.AddWithValue("@MaP", txtmap.Text);
                cmd.Parameters.AddWithValue("@TenP", txttenp.Text);
                cmd.Parameters.AddWithValue("@LoaiP", cbloaip.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@GiaP", decimal.Parse(txtgiap.Text)); 
                cmd.Parameters.AddWithValue("@Tinhtrang", cbtinhtrang.SelectedItem.ToString()); 
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã thêm phòng thành công");
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập giá hợp lệ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm phòng" + ex.Message);
            }
            finally
            {
                closeConnect();
                LoadPhong();
                ClearPhong();
            }
        }
        private void ClearPhong()
        {
            txtmap.Clear();
            txttenp.Clear();
            txtgiap.Clear();
            cbloaip.SelectedIndex = -1;
            cbtinhtrang.SelectedIndex = -1; 
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string maPhong = txtmap.Text.Trim();
            if (string.IsNullOrEmpty(maPhong))
            {
                MessageBox.Show("Vui lòng nhập mã phòng để xóa.");
                return;
            }

            try
            {
                var confirmResult = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa phòng {maPhong} không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmResult != DialogResult.Yes)
                {
                    return; 
                }
                openConnect();
                SqlCommand cmd = new SqlCommand("DELETE FROM Phong WHERE MaP = @MaP", conn);
                cmd.Parameters.AddWithValue("@MaP", maPhong);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show($"Phòng {maPhong} đã được xóa thành công.");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phòng với mã đã nhập.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa phòng: " + ex.Message);
            }
            finally
            {
                closeConnect();
                LoadPhong();
                txtmap.Clear(); 
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (danhsachphong.SelectedRows.Count > 0)
            {
                try
                {
                    openConnect();
                    var selectedRow = danhsachphong.SelectedRows[0];
                    string maPhong = selectedRow.Cells["MaP"].Value.ToString();

                    SqlCommand cmd = new SqlCommand(
                        "UPDATE Phong SET TenP = @TenP, LoaiP = @LoaiP, GiaP = @GiaP, Tinhtrang = @Tinhtrang WHERE MaP = @MaP",
                        conn
                    );
                    cmd.Parameters.AddWithValue("@MaP", maPhong);
                    cmd.Parameters.AddWithValue("@TenP", txttenp.Text);
                    cmd.Parameters.AddWithValue("@LoaiP", cbloaip.SelectedItem?.ToString() ?? string.Empty);
                    cmd.Parameters.AddWithValue("@GiaP", decimal.TryParse(txtgiap.Text, out var giaP) ? giaP : 0);
                    cmd.Parameters.AddWithValue("@Tinhtrang", cbtinhtrang.SelectedItem?.ToString() ?? string.Empty);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Phòng đã sửa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Không có thay đổi nào được thực hiện");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi sửa thông tin phòng" + ex.Message);
                }
                finally
                {
                    closeConnect();
                    LoadPhong(); 
                    ClearPhong();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phòng để sửa");
            }
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void danhsachphong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && danhsachphong.Rows[e.RowIndex].Cells["MaP"].Value != null)
            {
                DataGridViewRow row = danhsachphong.Rows[e.RowIndex];
                txtmap.Text = row.Cells["MaP"].Value.ToString();
                txttenp.Text = row.Cells["TenP"].Value.ToString();
                txtgiap.Text = row.Cells["GiaP"].Value.ToString();
                cbloaip.SelectedItem = row.Cells["LoaiP"].Value?.ToString() ?? string.Empty;
                cbtinhtrang.SelectedItem = row.Cells["Tinhtrang"].Value?.ToString() ?? string.Empty;
            }
        }
    }
}