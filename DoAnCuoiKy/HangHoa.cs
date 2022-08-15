using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHang
{
    class HangHoa
    {
        private string maHH;
        private string tenHH;
        private string loai;
        private string donGia;
        private DateTime ngayNhapKho;
        private int soLuong;

        public HangHoa(string maHH, string tenHH, string loai, string donGia, DateTime ngayNhapKho, int soLuong)
        {
            this.maHH = maHH;
            this.tenHH = tenHH;
            this.loai = loai;
            this.donGia = donGia;
            this.ngayNhapKho = ngayNhapKho;
            this.soLuong = soLuong;
        }

        public string MaHH { get => maHH; set => maHH = value; }
        public string TenHH { get => tenHH; set => tenHH = value; }
        public string Loai { get => loai; set => loai = value; }
        public string DonGia { get => donGia; set => donGia = value; }
        public DateTime NgayNhapKho { get => ngayNhapKho; set => ngayNhapKho = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
