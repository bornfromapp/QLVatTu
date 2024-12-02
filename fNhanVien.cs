using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class fNhanVien : Form
    {
        Connection dbConnection = null;
        public fNhanVien()
        {
            InitializeComponent();
            string connectionString = "Data Source=MSI;Initial Catalog=ttt;Integrated Security=True";
             dbConnection = new Connection(connectionString);
            Load_NhanVien();

        }

        private void Load_NhanVien()
        {
            string query = "SELECT * FROM NguoiDung";
            DataTable data = dbConnection.ExecuteQuery(query);
            dg_nhanvien.DataSource = data;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dg_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dg_nhanvien.Rows[e.RowIndex];

                // Gán giá trị từ DataGridView vào các TextBox
                txt_manv.Text = row.Cells["manguoidung"].Value.ToString();
                txt_hoten.Text = row.Cells["hoten"].Value.ToString();
                txt_sdt.Text = row.Cells["sdt"].Value.ToString();
                txt_chucvu.Text = row.Cells["machucvu"].Value.ToString();
                txt_email.Text = row.Cells["email"].Value.ToString();
            }
        }
    }
}
