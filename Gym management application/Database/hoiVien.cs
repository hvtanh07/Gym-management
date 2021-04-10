using System.Data.SqlClient;
using System.Data;
using System;

namespace Gym_management_appication.Database
{
    class hoiVien
    {
        private string sqlQuery;
        private DataTable result = new DataTable();
        public DataTable getMemberofMonth (DateTime fromDate, DateTime toDate)
        {
            sqlQuery = "SELECT bucketName AS thang, " +
                       "(SELECT COUNT(*) FROM DanhSachHoiVien WHERE ngayThamGia <= bucketLastDay)"+
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
            sqlQuery = "SELECT bucketName AS thang, " +
                       "(SELECT COUNT(*) FROM DanhSachHoiVien WHERE MONTH(ngayThamGia) = MONTH(bucketLastDay)) as total" +
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
            sqlQuery = "SELECT bucketName AS thang, " +
                       "(SELECT COUNT(*) FROM DanhSachHoiVien WHERE MONTH(ngayKetThuc) = MONTH(bucketLastDay)) as total" +
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
    }
}
