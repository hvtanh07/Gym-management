using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_management_appication
{
    class DanhSachNhanVienModel
    {
        private static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database.mdf;Integrated Security=True";
        SqlConnection Cnt;
        public DanhSachNhanVienModel()
        {
            Cnt = new SqlConnection(connectionString);
        }
        public void Insert(string ID, string Ten, string GioiTinh, string Email, string SDT, string DiaChi, string ChucVu, long Luong)
        {
            Cnt.Open();
            string sqlInsert = "INSERT INTO dbo.[NHANVIEN](ID,HoTen, GioiTinh, Email, SoDT, DiaChi,ChucVu,Luong) VALUES (@ID, @HoTen, @GioiTinh, @Email, @SoDT, @DiaChi, @ChucVu,@Luong)";
            SqlCommand cmd = new SqlCommand(sqlInsert, Cnt);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@HoTen", Ten);
            cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@SoDT", SDT);
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            cmd.Parameters.AddWithValue("@ChucVu",ChucVu);
            cmd.Parameters.AddWithValue("@Luong", Luong);
            cmd.ExecuteNonQuery();
            Cnt.Close();
        }

        public void Update(string Hoten, string GioiTinh, string Email, string SoDt, string ID, string Password, bool IsAdmin)
        {
            Cnt.Open();
            string sqlUpdate = "UPDATE dbo.[ID_PASSWORD] SET HoTen = @HoTen, Email = @Email, GioiTinh = @GioiTinh, SoDT = @SoDT, PASSWORD = @Password, IsAdmin = @IsAdmin WHERE ID =@ID";
            SqlCommand cmd = new SqlCommand(sqlUpdate, Cnt);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@PASSWORD", Password);
            cmd.Parameters.AddWithValue("@HoTen", Hoten);
            cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@SoDT", SoDt);
            cmd.Parameters.AddWithValue("@IsAdmin", IsAdmin);
            cmd.ExecuteNonQuery();
            Cnt.Close();
        }

        public void Delete(string ID)
        {
            Cnt.Open();
            string sqlDelete = "DELETE FROM dbo.[ID_PASSWORD] WHERE ID = @ID;";
            SqlCommand cmd = new SqlCommand(sqlDelete, Cnt);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.ExecuteNonQuery();
            Cnt.Close();
        }
        public bool CheckID(String ID)
        {
            Cnt.Open();
            string sqlSelect = "Select * from  dbo.[Table];";
            SqlDataAdapter cmd = new SqlDataAdapter(sqlSelect, Cnt);
            System.Data.DataTable temp = new System.Data.DataTable();
            cmd.Fill(temp);
            for (int i = 0; i < temp.Rows.Count; i++)
                if (temp.Rows[i][0].ToString() == ID)
                {
                    Cnt.Close();
                    return true;
                }
            Cnt.Close();
            return false;
        }

        public void InsertXoaNV(string maAdmin, string maNhanVien, string Ngay)
        {
            Cnt.Open();
            string sqlInsert = "INSERT INTO dbo.[Xoa_NV](MaAdmin, MaNhanVienDaXoa, Ngay) VALUES (@MaAdmin, @MaNhanVienDaXoa,@Ngay)";
            SqlCommand cmd = new SqlCommand(sqlInsert, Cnt);
            cmd.Parameters.AddWithValue("@MaAdmin", maAdmin);
            cmd.Parameters.AddWithValue("@MaNhanVienDaXoa", maNhanVien);
            cmd.Parameters.AddWithValue("@Ngay", Ngay);
            cmd.ExecuteNonQuery();
            Cnt.Close();
        }

        public System.Data.DataTable GetDatabase(string Sql)
        {
            Cnt.Open();
            string sqlSelect = Sql;
            SqlDataAdapter cmd = new SqlDataAdapter(sqlSelect, Cnt);
            System.Data.DataTable temp = new System.Data.DataTable();
            cmd.Fill(temp);
            Cnt.Close();
            return temp;
        }
    }
}
