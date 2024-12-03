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
    public partial class TimKiemP : Form
    {
        private readonly string connectionString = "Server=(LocalDB)\\MSSQLLocalDB; Database=QLThuePhong;Integrated Security=True";
        public SqlConnection conn;
        public TimKiemP()
        {
            InitializeComponent();
            LoadRoomStatus();
            LoadRoomTypes();
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

        private void LoadRoomTypes()
        {
            var roomTypes = new[] {
                "Đơn thường",
                "Đôi thường",
                "Ba thường",
                "VIP đơn",
                "VIP đôi",
                "VIP ba"
            };
            cbb_loai.DataSource = roomTypes;
            cbb_loai.SelectedIndex = -1; 
        }

        private void LoadRoomStatus()
        {
            var roomStatuses = new[] {
                "Trống",
                "Có khách"
            };
            cbb_tinhtrang.DataSource = roomStatuses;
            cbb_tinhtrang.SelectedIndex = -1; 
        }
        private void btn_Timkiem_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Phong WHERE 1 = 1";
            if (cb_loaip.Checked && cbb_loai.SelectedIndex != -1)
            {
                query += " AND LoaiP = @LoaiP";
            }
            if (cb_tinhtrang.Checked && cbb_tinhtrang.SelectedIndex != -1)
            {
                query += " AND Tinhtrang = @Tinhtrang";
            }

            try
            {
                openConnect();
                SqlCommand cmd = new SqlCommand(query, conn);

                if (cb_loaip.Checked && cbb_loai.SelectedIndex != -1)
                {
                    cmd.Parameters.AddWithValue("@LoaiP", cbb_loai.SelectedItem.ToString());
                }

                if (cb_tinhtrang.Checked && cbb_tinhtrang.SelectedIndex != -1)
                {
                    cmd.Parameters.AddWithValue("@Tinhtrang", cbb_tinhtrang.SelectedItem.ToString());
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                gv_ketqua.DataSource = dt;
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
