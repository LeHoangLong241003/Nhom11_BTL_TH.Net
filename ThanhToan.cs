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
    public partial class ThanhToan : Form
    {
      private readonly string connectionString = "Server=(LocalDB)\\MSSQLLocalDB; Database=QLThuePhong;Integrated Security=True";
        private SqlConnection conn;


        public ThanhToan()
        {
            InitializeComponent();
            LoadThanhToan();

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

        private void LoadThanhToan(string searchText = "")
        {
            string query = "SELECT * FROM ThanhToan"; 

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
                    thanhtoandataGridView2.DataSource = dt; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
                }
            }
        }

        private void thanhtoandataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            decimal totalAmount = 0;
            DataTable allRentalsAndServices = new DataTable();

            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    allRentalsAndServices.Columns.Add("MaHD", typeof(string));
                    allRentalsAndServices.Columns.Add("TenDV", typeof(string));
                    allRentalsAndServices.Columns.Add("DonGia", typeof(decimal));
                    allRentalsAndServices.Columns.Add("SoLuong", typeof(int));
                    allRentalsAndServices.Columns.Add("ThanhTien", typeof(decimal));
                    string rentalQuery = "SELECT MaHD, CMT, SoLuong FROM ThueP WHERE DaThanhToan = 0"; 
                    SqlDataAdapter rentalAdapter = new SqlDataAdapter(rentalQuery, conn);
                    DataTable rentalData = new DataTable();
                    rentalAdapter.Fill(rentalData);

                    foreach (DataRow row in rentalData.Rows)
                    {
                        string maHD = row["MaHD"].ToString();
                        decimal donGia = Convert.ToDecimal(row["DonGia"]);
                        int soLuong = Convert.ToInt32(row["SoLuong"]);
                        decimal thanhTien = donGia * soLuong;
                        totalAmount += thanhTien;

                        allRentalsAndServices.Rows.Add(maHD, "Thuê phòng", donGia, soLuong, thanhTien);
                    }
                    string serviceQuery = "SELECT MaHD, MaDV, DonGia, Soluong FROM SDDV WHERE DaThanhToan = 0"; 
                    SqlDataAdapter serviceAdapter = new SqlDataAdapter(serviceQuery, conn);
                    DataTable serviceData = new DataTable();
                    serviceAdapter.Fill(serviceData);

                    foreach (DataRow row in serviceData.Rows)
                    {
                        string maHD = row["MaHD"].ToString();
                        string maDV = row["MaDV"].ToString(); 
                        decimal donGia = Convert.ToDecimal(row["DonGia"]);
                        int soLuong = Convert.ToInt32(row["Soluong"]);
                        decimal thanhTien = donGia * soLuong;
                        totalAmount += thanhTien;
                        allRentalsAndServices.Rows.Add(maHD, maDV, donGia, soLuong, thanhTien);
                    }
                    thanhtoandataGridView2.DataSource = allRentalsAndServices;
                }
                MessageBox.Show($"Tổng tiền cần thanh toán: {totalAmount.ToString("C2")}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tính toán tổng tiền: " + ex.Message);
            }
        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {

        }
    }
}
