using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyKhoHang
{
    class DALKhoHang
    {
        private static string stringDALKhoHang = @"Data Source=LENOVO;Initial Catalog=QUAN_LY_KHO_HANG;Integrated Security=True";
        public static SqlConnection getConnection()
        {
            return new SqlConnection(stringDALKhoHang);
        }
        
    }
}
