using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_management_appication.Database
{
    class hoiVien
    {
        private string sqlQuery;
        private DataTable result = new DataTable();
        public DataTable getData()
        {
            sqlQuery = "select month (ngayThamGia) as Month, count (ma) as Total " +
                "from [DanhSachHoiVien] where ngayThamGia is not null " +
                "group by month(ngayThamGia) " +
                "order by month(ngayThamGia) asc";
            conString.ConString constring = new conString.ConString();    //this will hide the database info ... sort of                
            try
            {
                using (var con = new SqlConnection(constring.initString()))
                {
                    using (var cmd = new SqlCommand(sqlQuery, con))
                    {
                        con.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        // this will query your database and return the result to your datatable
                        da.Fill(result);
                        con.Close();

                    }
                }
            }
            catch (SqlException ex)
            {

            }
            return result;
        }


    }
}
