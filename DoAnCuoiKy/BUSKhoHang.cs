using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyKhoHang
{
    class BUSKhoHang
    {
        SqlDataAdapter dataAdapter;
        //hđ như 1 cầu kết nối giữa data set hoặc datatable vào nguồn dữ liệu để struy xuất dữ liệu vao bang
      public BUSKhoHang()
        {

        }
      public DataTable getAllHangHoa()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from HANG_HOA";
            using (SqlConnection sqlConnection = DALKhoHang.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);//lấp đầy toàn bộ dữ liệu vào bảng
                sqlConnection.Close();
            }//khi khỏi tạo tượng sql và chương trình thực thì mà mở kết nối mà quên k đóng thì sẽ xoá hết dữ liệu 
            return dataTable;
        }
    }
}
