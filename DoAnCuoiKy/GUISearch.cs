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
    public partial class GUISearch : Form
    {
        public GUISearch()
        {
            InitializeComponent();
        }

        private void GUISearch_Load(object sender, EventArgs e)
        {
            guna2ComboBox1.Items.Insert(0, "Tìm theo khoảng giá!");
            guna2ComboBox1.SelectedIndex = 0;
        }
    }
}
