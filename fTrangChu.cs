using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class fTrangChu : Form
    {
        public fTrangChu()
        {
            InitializeComponent();
        }

        private void btn_fnhanvien_Click(object sender, EventArgs e)
        {
            fNhanVien NVForm = new fNhanVien();
            NVForm.FormBorderStyle = FormBorderStyle.None;
            NVForm.Dock = DockStyle.Fill;
            NVForm.TopLevel = false;
            // Thêm form vào panel và hiển thị
            pn_childform.Controls.Add(NVForm);
           NVForm.Show();
        }

        private void lb_username_Click(object sender, EventArgs e)
        {

        }
    }
}
