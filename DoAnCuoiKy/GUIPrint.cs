using System;
using System.Windows.Forms;

namespace QuanLyKhoHang
{
    public partial class GUIPrint : Form
    {
        public GUIPrint()
        {
            InitializeComponent();
        }

        private void GUIPrint_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUAN_LY_KHO_HANGDataSet1.HANG_HOA' table. You can move, or remove it, as needed.
            this.hANG_HOATableAdapter1.Fill(this.qUAN_LY_KHO_HANGDataSet1.HANG_HOA);

            this.reportViewer2.RefreshReport();
        }
    }
}
