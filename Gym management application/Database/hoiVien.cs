using System.Data.SqlClient;
using System.Data;
using System;

namespace Gym_management_appication.Database
{
    class hoiVien
    {
        private string sqlQuery;
        private DataTable result = new DataTable();
        public DataTable getMemberList()
        {
            sqlQuery = "Select Trim(DanhSachHoiVien.ma) + ' - ' + trim(DanhSachHoiVien.ten) as list" +
                       " From  DanhSachHoiVien ";
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
        public DataTable getMemberListCode()
        {
            sqlQuery = "Select Trim(DanhSachHoiVien.ma) as list" +
                       " From  DanhSachHoiVien ";
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
        public DataTable getMemberDetailInfo(string ma)
        {
            sqlQuery = "Select ma, ten from DanhSachHoiVien " +
                       " where ma = '" + ma + "' ";
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
        public DataTable getMemberofMonth (DateTime fromDate, DateTime toDate)
        {
            sqlQuery = "SELECT bucketName AS thang," +
                       " (SELECT COUNT(*) FROM DanhSachHoiVien WHERE ngayThamGia <= bucketLastDay)"+
                       "- (SELECT COUNT(*) FROM DanhSachHoiVien WHERE ngayKetThuc<bucketFirstDay) as total"+
                       " FROM monthBucket WHERE bucketLastDay >= '"+ fromDate +"' AND bucketFirstDay <= '" + toDate + "'"+
                       " ORDER BY bucketFirstDay";
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
        public DataTable getNewMemberofMonth(DateTime fromDate, DateTime toDate)
        {
            sqlQuery = "SELECT bucketName AS thang," +
                       " (SELECT COUNT(*) FROM DanhSachHoiVien WHERE MONTH(ngayThamGia) = MONTH(bucketLastDay)) as total" +
                       " FROM monthBucket WHERE bucketLastDay >= '" + fromDate + "' AND bucketFirstDay <= '" + toDate + "'" +
                       " ORDER BY bucketFirstDay";
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
        public DataTable getResignMemberofMonth(DateTime fromDate, DateTime toDate)
        {
            sqlQuery = "SELECT bucketName AS thang," +
                       " (SELECT COUNT(*) FROM DanhSachHoiVien WHERE MONTH(ngayKetThuc) = MONTH(bucketLastDay)) as total" +
                       " FROM monthBucket WHERE bucketLastDay >= '" + fromDate + "' AND bucketFirstDay <= '" + toDate + "'" +
                       " ORDER BY bucketFirstDay";
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
                        con.Dispose();
                    }
                }
            }
            catch (SqlException ex)
            {

            }
            return result;
        }
        public DataTable getMemberpaymentinfo(String maHV)
        {
            sqlQuery = "Select DanhSachHoiVien.ten as HoiVien, MonthlyIncome.dateOfPay," +
                       " trim(GoiTap.ma) + ' - ' + trim(GoiTap.ten) as Goi, MonthlyIncome.price" +
                       " From MonthlyIncome inner join DanhSachHoiVien on DanhSachHoiVien.ma = MonthlyIncome.maKH inner join" +
                       " GoiTap	on GoiTap.ma = MonthlyIncome.maGoiTap" +
                       " Where DanhSachHoiVien.ma = '" + maHV + "'";
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
                        con.Dispose();
                    }
                }
            }
            catch (SqlException ex)
            {

            }
            return result;
        }
        public DateTime getMemberExpireday(String maHV)
        {
            DateTime date = DateTime.Today;
            sqlQuery = "Select DATEADD(MONTH, SUM(PaymentPeriod), DanhSachHoiVien.ngayThamGia) AS expireDate" +
                       " From DanhSachHoiVien inner join MonthlyIncome on DanhSachHoiVien.ma = MonthlyIncome.maKH" +
                       " Where DanhSachHoiVien.ma = '" + maHV + "'" +
                       " Group by DanhSachHoiVien.ngayThamGia, DanhSachHoiVien.ma";
            conString.ConString constring = new conString.ConString();             
            try
            {
                using (var con = new SqlConnection(constring.initString()))
                {
                    using (var cmd = new SqlCommand(sqlQuery, con))
                    {
                        con.Open();
                        date = DateTime.Parse(cmd.ExecuteScalar().ToString());
                        con.Dispose();
                    }
                }
            }
            catch (SqlException ex)
            {

            }
            return date;
        }
        public DataTable AddPayment(string ID, string maKH, string maGoiTap, DateTime dateOfPay,int PaymentPeriod,int price)
        {
            sqlQuery = "insert into MonthlyIncome (ID, maKH, maGoiTap, dateOfPay, PaymentPeriod, price) " +
                       " values (N'" + ID + "','" + maKH + "','" + maGoiTap + "','" + dateOfPay + "'," + PaymentPeriod + "," + price + ")";
            conString.ConString constring = new conString.ConString();    //this will hide the database info ... sort of                
            try
            {
                using (var con = new SqlConnection(constring.initString()))
                {
                    using (var cmd = new SqlCommand(sqlQuery, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                }
            }
            catch (SqlException ex)
            {

            }
            return result;
        }
        public DataTable DeletePayment(string maKH, DateTime dateOfPay)
        {
            sqlQuery = "Delete from MonthlyIncome where maKH = '" + maKH + "' AND " +
                       "year(dateOfPay) = '"+ dateOfPay.Year + "' and month(dateOfPay) = '" + dateOfPay.Month + "' and day(dateOfPay) = '" + dateOfPay.Day + "'";
            conString.ConString constring = new conString.ConString();    //this will hide the database info ... sort of                
            try
            {
                using (var con = new SqlConnection(constring.initString()))
                {
                    using (var cmd = new SqlCommand(sqlQuery, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                }
            }
            catch (SqlException ex)
            {

            }
            return result;
        }
        public string GetIDfromName(string ten)
        {
            sqlQuery = "select ma from DanhSachHoiVien where ten = N'" + ten + "'" ;
            string ma = "";
            conString.ConString constring = new conString.ConString();    //this will hide the database info ... sort of                
            try
            {
                using (var con = new SqlConnection(constring.initString()))
                {
                    using (var cmd = new SqlCommand(sqlQuery, con))
                    {
                        con.Open();
                        ma = cmd.ExecuteScalar().ToString();
                        con.Dispose();
                    }
                }
            }
            catch (SqlException ex)
            {

            }
            return ma;
        }
    }
}
