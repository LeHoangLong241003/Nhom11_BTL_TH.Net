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
    public partial class TraPhong : Form
    {
        private readonly string connectionString = "Server=(LocalDB)\\MSSQLLocalDB; Database=QLThuePhong;Integrated Security=True";
        private SqlConnection conn;

        public TraPhong()
        {
            InitializeComponent();
            LoadThuePhong();
            LoadSuDungDichVu();
        }

        private void openConnect()
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
        }

        private void closeConnect()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void LoadThuePhong(string searchText = "")
        {
            string query = "SELECT * FROM ThueP";

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                query += " WHERE MaHD LIKE @SearchText OR MaP LIKE @SearchText";
            }

            using (var conn = new SqlConnection(connectionString))
            using (var adapter = new SqlDataAdapter(query, conn))
            {
                if (!string.IsNullOrWhiteSpace(searchText))
                {
                    adapter.SelectCommand.Parameters.Add(new SqlParameter("@SearchText", $"%{searchText}%"));
                }

                DataTable dt = new DataTable();
                try
                {
                    conn.Open();
                    adapter.Fill(dt);
                    thuedataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
                }
            }
        }
        private void LoadSuDungDichVu()
        {
            try
            {
                openConnect();
                string query = "SELECT * FROM SDDV";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dichvudataGridView2.DataSource = dt;
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


        private void TraPhong_Load(object sender, EventArgs e)
        {
        }
        

        private void btn_trap_Click(object sender, EventArgs e)
        {
            if (thuedataGridView1.SelectedRows.Count > 0)
            {
                var row = thuedataGridView1.SelectedRows[0];
                string maHD = row.Cells["MaHD"].Value.ToString();
                DateTime ngayTraPhong = DateTime.Now; 

                try
                {
                    openConnect();
                    string query = "UPDATE ThueP SET Ngaydi = @NgayTraPhong WHERE MaHD = @MaHD";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@NgayTraPhong", ngayTraPhong);
                        command.Parameters.AddWithValue("@MaHD", maHD);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Trả phòng thành công!");
                        ThanhToan thanhToan = new ThanhToan();
                        thanhToan.Show();
                        LoadThuePhong(); 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi trả phòng: " + ex.Message);
                }
                finally
                {
                    closeConnect();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để trả phòng.");
            }
        }
        private void txt_input_TextChanged(object sender, EventArgs e)
        {
            string searchText = txt_input.Text.Trim();
            LoadThuePhong(searchText);
        }

        private void btn_timtenkh_Click(object sender, EventArgs e)
        {
            string cmt = txt_input.Text.Trim();

            if (!string.IsNullOrEmpty(cmt))
            {
                LoadThuePhongByCMT(cmt);
                LoadSuDungDichVuByCMT(cmt);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số CMT để tìm kiếm.");
            }
        }
        private void LoadThuePhongByCMT(string cmt)
        {
            string query = "SELECT * FROM ThueP WHERE CMT = @CMT"; 

            using (var conn = new SqlConnection(connectionString))
            using (var adapter = new SqlDataAdapter(query, conn))
            {
                adapter.SelectCommand.Parameters.Add(new SqlParameter("@CMT", cmt));

                DataTable dt = new DataTable();
                try
                {
                    conn.Open();
                    adapter.Fill(dt);
                    thuedataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
                }
            }
        }

        private void LoadSuDungDichVuByCMT(string cmt)
        {
            string query = "SELECT * FROM SDDV WHERE CMT = @CMT"; 

            using (var conn = new SqlConnection(connectionString))
            using (var adapter = new SqlDataAdapter(query, conn))
            {
                adapter.SelectCommand.Parameters.Add(new SqlParameter("@CMT", cmt));

                DataTable dt = new DataTable();
                try
                {
                    conn.Open();
                    adapter.Fill(dt);
                    dichvudataGridView2.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu dịch vụ: " + ex.Message);
                }
            }
        }
    }
}

