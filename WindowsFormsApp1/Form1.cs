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

namespace WindowsFormsApp1
{
    public partial class form : Form
    {
        string chuoiketnoi = "Data Source=(local);" +
                             "Initial Catalog=QuanLyThuVien;" +
                             "Integrated Security=True";
        SqlConnection conn;

        public form()
        {
            InitializeComponent();
            dtgSach.AutoGenerateColumns = false;
        }
        private void combobox_TenSV_TenSach()
        {
            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                string sql = "select * from SinhVien";
                SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
                DataTable dtSV = new DataTable();
                adp.Fill(dtSV);
                cbTenSV.DataSource = dtSV;
                cbTenSV.DisplayMember = "HoTen";
                cbTenSV.ValueMember = "MaSV";

                sql = "select * from Sach";
                adp = new SqlDataAdapter(sql, conn);
                DataTable dtSach = new DataTable();
                adp.Fill(dtSach);
                cbTenSach.DataSource = dtSach;
                cbTenSach.DisplayMember = "TenSach";
                cbTenSach.ValueMember = "MaSach";
            }

        }
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                conn.Open();
                string sql = "select * from Sach";
                SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
                DataTable dtSach = new DataTable();
                adp.Fill(dtSach);
                dtgSach.Columns["Column2"].DataPropertyName = "MaSach";
                dtgSach.Columns["Column3"].DataPropertyName = "TenSach";
                dtgSach.DataSource = dtSach;
            }
        }
        private void form_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            timeMuon.MinDate = DateTime.Now;
            LoadData();
            combobox_TenSV_TenSach();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ma_sach = tb1.Text;
            string ten_sach = tb2.Text;
            string sql_Insert = "Insert into Sach (MaSach, TenSach) values(@ma_sach, @ten_sach)";
            using (SqlCommand cmd = new SqlCommand(sql_Insert, conn))
            {
                cmd.Parameters.AddWithValue("@ma_sach", ma_sach);
                cmd.Parameters.AddWithValue("@ten_sach", ten_sach);
                cmd.ExecuteNonQuery();
                LoadData();
            }



        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
