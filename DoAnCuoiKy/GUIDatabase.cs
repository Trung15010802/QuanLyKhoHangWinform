using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang
{
    public partial class GUIDatabase : Form
    {
        public GUIDatabase()
        {
            InitializeComponent();
        }
        BUSKhoHang busKhoHang;

        private void GUIDatabase_Load(object sender, EventArgs e)
        {
            busKhoHang = new BUSKhoHang();
            try
            {
                guna2DataGridView1.DataSource = busKhoHang.getAllHangHoa();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
