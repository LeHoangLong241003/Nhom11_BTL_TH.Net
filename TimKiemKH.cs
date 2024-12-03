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
    public partial class TimKiemKH : Form
    {
        private readonly string connectionString = "Server=(LocalDB)\\MSSQLLocalDB; Database=QLThuePhong;Integrated Security=True";
        private SqlConnection conn;
        public TimKiemKH()
        {
            InitializeComponent();
            LoadKhach();
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
        private void LoadKhach()
        {
            try
            {
                openConnect();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Khach", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                gv_ketqua.DataSource = dt;
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
        private void TimKiemKH_Load(object sender, EventArgs e)
        {
            string keyword = txttimkiemkh.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.");
                return;
            }

            string query = "";

            if (rbt_cmt.Checked)
            {
                query = "SELECT * FROM Khach WHERE CMT LIKE @Keyword";
            }
            else if (rbt_tenkh.Checked)
            {
                query = "SELECT * FROM Khach WHERE HoTen LIKE @Keyword";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phương thức tìm kiếm.");
                return;
            }

            try
            {
                openConnect();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    gv_ketqua.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả phù hợp.");
                    gv_ketqua.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
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
    }
}
