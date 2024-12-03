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
    public partial class SuDungDV : Form
    {
        private readonly string connectionString = "Server=(LocalDB)\\MSSQLLocalDB; Database=QLThuePhong;Integrated Security=True";
        public SqlConnection conn;

        public SuDungDV()
        {
            InitializeComponent();
            LoadSuDungDichVu();
        }
        private void OpenConnection()
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
        }

        private void CloseConnection()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        private void LoadSuDungDichVu()
        {
            try
            {
                OpenConnection();
                string query = "SELECT * FROM SDDV";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                sDDVDataGridView.DataSource = dt; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        

        private void SuDungDV_Load(object sender, EventArgs e)
        {

        }

        private void btnthemsddv_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcmt.Text) ||
        string.IsNullOrWhiteSpace(txtmadv.Text) ||
        string.IsNullOrWhiteSpace(txtmap.Text) ||
        string.IsNullOrWhiteSpace(txtsoluong.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            if (!int.TryParse(txtsoluong.Text, out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải là một số dương.");
                return;
            }

            string cmt = txtcmt.Text;
            string maDichVu = txtmadv.Text;
            string maPhong = txtmap.Text;
            DateTime ngaySuDung = txtngaysd.Value;

            try
            {
                OpenConnection();
                string checkCmtQuery = "SELECT COUNT(*) FROM Khach WHERE CMT = @CMT";
                using (SqlCommand checkCmtCmd = new SqlCommand(checkCmtQuery, conn))
                {
                    checkCmtCmd.Parameters.AddWithValue("@CMT", cmt);
                    int count = (int)checkCmtCmd.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("Không có mã khách hàng nào với CMT: " + cmt);
                        return; 
                    }
                }
                string checkPhongQuery = "SELECT COUNT(*) FROM Phong WHERE MaP = @MaPhong";
                using (SqlCommand checkPhongCmd = new SqlCommand(checkPhongQuery, conn))
                {
                    checkPhongCmd.Parameters.AddWithValue("@MaPhong", maPhong);
                    int count = (int)checkPhongCmd.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("Không có mã phòng nào với MaPhong: " + maPhong);
                        return;
                    }
                }
                string checkDichVuQuery = "SELECT COUNT(*) FROM Dichvu WHERE MaDV = @MaDichVu";
                using (SqlCommand checkDichVuCmd = new SqlCommand(checkDichVuQuery, conn))
                {
                    checkDichVuCmd.Parameters.AddWithValue("@MaDichVu", maDichVu);
                    int count = (int)checkDichVuCmd.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("Không có mã dịch vụ nào với MaDV: " + maDichVu);
                        return;
                    }
                }
                string query = "INSERT INTO SDDV (CMT, MaDV, MaP, Soluong, NgaySD) " +
                               "VALUES (@CMT, @MaDichVu, @MaPhong, @SoLuong, @NgaySuDung)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CMT", cmt);
                    cmd.Parameters.AddWithValue("@MaDichVu", maDichVu);
                    cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                    cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                    cmd.Parameters.AddWithValue("@NgaySuDung", ngaySuDung);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Thêm thông tin dịch vụ thành công.");
                        LoadSuDungDichVu();
                        ClearInputFields();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thông tin dịch vụ thất bại.");
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Lỗi SQL: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm thông tin: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        private void ClearInputFields()
        {
            txtcmt.Clear();
            txtmadv.Clear();
            txtmap.Clear();
            txtsoluong.Clear();
            txtngaysd.Value = DateTime.Now;
        }
        private void btnsuasddv_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcmt.Text) ||
        string.IsNullOrWhiteSpace(txtmadv.Text) ||
        string.IsNullOrWhiteSpace(txtmap.Text) ||
        string.IsNullOrWhiteSpace(txtsoluong.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            if (!int.TryParse(txtsoluong.Text, out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải là một số dương.");
                return;
            }

            string cmt = txtcmt.Text;
            string maDichVu = txtmadv.Text;
            string maPhong = txtmap.Text;
            DateTime ngaySuDung = txtngaysd.Value;

            try
            {
                OpenConnection();
                string query = "UPDATE SDDV SET MaDV = @MaDichVu, MaP = @MaPhong, Soluong = @SoLuong, NgaySD = @NgaySuDung " +
                               "WHERE CMT = @CMT AND MaP = @MaPhong "; 
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CMT", cmt);
                    cmd.Parameters.AddWithValue("@MaDichVu", maDichVu);
                    cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                    cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                    cmd.Parameters.AddWithValue("@NgaySuDung", ngaySuDung);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Cập nhật thông tin dịch vụ thành công.");
                        LoadSuDungDichVu();
                        ClearInputFields();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin dịch vụ thất bại.");
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Lỗi SQL: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật thông tin: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        private void btnxoasddv_Click(object sender, EventArgs e)
        {
            string cmt = txtcmt.Text;
            string maDichVu = txtmadv.Text;
            string maPhong = txtmap.Text;

            if (string.IsNullOrWhiteSpace(cmt) || string.IsNullOrWhiteSpace(maDichVu) || string.IsNullOrWhiteSpace(maPhong))
            {
                MessageBox.Show("Vui lòng chọn một dịch vụ để xóa.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa dịch vụ này không?", "Xóa dịch vụ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    OpenConnection();
                    string query = "DELETE FROM SDDV WHERE CMT = @CMT AND MaDV = @MaDichVu AND MaP = @MaPhong"; 
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CMT", cmt);
                        cmd.Parameters.AddWithValue("@MaDichVu", maDichVu);
                        cmd.Parameters.AddWithValue("@MaPhong", maPhong);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Xóa dịch vụ thành công.");
                            LoadSuDungDichVu();
                            ClearInputFields();
                        }
                        else
                        {
                            MessageBox.Show("Xóa dịch vụ thất bại.");
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("Lỗi SQL: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa thông tin: " + ex.Message);
                }
                finally
                {
                    CloseConnection();
                }
            }
        }

        private void btnthoatsddv_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void sDDVDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (sDDVDataGridView.CurrentRow != null)
            {
                txtcmt.Text = sDDVDataGridView.CurrentRow.Cells["CMT"].Value.ToString();
                txtmadv.Text = sDDVDataGridView.CurrentRow.Cells["MaDV"].Value.ToString();
                txtmap.Text = sDDVDataGridView.CurrentRow.Cells["MaP"].Value.ToString();
                txtsoluong.Text = sDDVDataGridView.CurrentRow.Cells["Soluong"].Value.ToString();
                txtngaysd.Value = Convert.ToDateTime(sDDVDataGridView.CurrentRow.Cells["NgaySD"].Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DichVu dichVu = new DichVu();
            dichVu.Show();
        }
    }
}
