using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
    public class DAL
    {
        public OracleConnection Connect(ThanhVien current_tv)
        {

            OracleConnection con = new OracleConnection();
            OracleConnectionStringBuilder str = new OracleConnectionStringBuilder();
            str.UserID = current_tv.USERNAME;
            str.Password = current_tv.password;
            str.DataSource = "localhost:1521/PDB";
            con.ConnectionString = str.ConnectionString;
            return con;
        }

        public ThanhVien Login(ThanhVien current_tv)
        {
            OracleConnection conn = new OracleConnection();
            conn = Connect(current_tv);
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"select USERTYPE from QLBC.TAIKHOAN where USERNAME = :usn";
                cmd.Parameters.Add(new OracleParameter("usn", current_tv.USERNAME));
                var er = cmd.ExecuteReader();
                er.Read();
                current_tv.VAITRO = er.GetString(0);
                conn.Close();
                return current_tv;
            }
            catch (OracleException)
            {
                conn.Close();
                return current_tv;
            }
            finally
            {
                conn.Close();
            }

        }

        public int GetMaTV(ThanhVien thanhVien)
        {
            OracleConnection conn = new OracleConnection();
            conn = Connect(thanhVien);
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"select matv from QLBC.THANHVIEN where USERNAME = :usn";
                cmd.Parameters.Add(new OracleParameter("usn", thanhVien.USERNAME));
                var er = cmd.ExecuteReader();
                er.Read();
                int maTV = er.GetInt32(0);
                conn.Close();
                return maTV ;
            }
            catch (OracleException)
            {
                conn.Close();
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }

        public DSUngVien[] GetDSUngViens(ThanhVien thanhVien)
        {
            OracleConnection conn = new OracleConnection();
            conn = Connect(thanhVien);
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"select mauv,hoten from qlbc.ungvien";
                var er = cmd.ExecuteReader();
                List<DSUngVien> dSUngViens = new List<DSUngVien>();
                while (er.Read())
                {
                    dSUngViens.Add(new DSUngVien()
                    {
                        maUV = er.GetInt32(0),
                        name = er.GetString(1)
                    }) ;
                }
                conn.Close();
                return dSUngViens.ToArray();
            }
            catch (OracleException)
            {
                conn.Close();
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        
        public bool createBauChon(ThanhVien thanhVien,List<DSUngVien> dSUngViens)
        {
            OracleConnection conn = new OracleConnection();
            conn = Connect(thanhVien);
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                foreach (var i in dSUngViens)
                {
                    string a = GetMaTV(thanhVien).ToString();
                    string b = i.maUV.ToString();
                    string cm = "insert into qlbc.bauchon values (" + a + " , " + b  + " );";
                    cmd.CommandText = cm;
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                return true;
            }
            catch (OracleException)
            {
                conn.Close();
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public ThongTinCaNhan GetThongTinCaNhan(ThanhVien thanhVien)
        {
            OracleConnection conn = new OracleConnection();
            conn = Connect(thanhVien);
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"select * from qlbc.thanhvien where matv = " + GetMaTV(thanhVien).ToString() ;
                var er = cmd.ExecuteReader();
                List<DSUngVien> dSUngViens = new List<DSUngVien>();
                er.Read();
                ThongTinCaNhan thongTinCaNhan = new ThongTinCaNhan()
                {
                    ma = er.GetInt32(0),
                    HoVaTen = er.GetString(1),
                    Phai = er.GetString(2),
                    QueQuan = er.GetString(3),
                    Ngaysinh = er.GetDateTime(4).ToString("dd/MM/yyyy"),
                    QuocTich = er.GetString(5),
                    DiaChiThuongTru = er.GetString(6),
                    DiaChiTamTru = er.GetString(7),
                    VaiTro = er.GetString(8),
                    MaDonVi = er.GetInt32(9),
                    ViTriCongTac = er.GetString(10),
                    NghiPhep = er.GetString(11),
                    LyDoNghiPhep = er.GetString(12),
                    UserName = er.GetString(13),
                    MaLinhVuc = er.GetInt32(14)
                };
                conn.Close();
                return thongTinCaNhan;
            }
            catch (OracleException)
            {
                conn.Close();
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<ThongBao> GetThongBaos(ThanhVien thanhVien)
        {
            OracleConnection conn = new OracleConnection();
            conn = Connect(thanhVien);
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"select * from qlbc.thongbao";
                var er = cmd.ExecuteReader();
                List<ThongBao> thongBaos = new List<ThongBao>();
                while (er.Read())
                {
                    thongBaos.Add(new ThongBao()
                    {
                       noidung = er.GetString(0)
                    });
                }
                conn.Close();
                return thongBaos;
            }
            catch (OracleException)
            {
                conn.Close();
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<DSBauCu> GetDSBauCus(ThanhVien thanhVien)
        {
            OracleConnection conn = new OracleConnection();
            conn = Connect(thanhVien);
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"select distinct t.matv, t.hoten from qlbc.bauchon b join qlbc.thanhvien t on b.matv = t.matv where t.madv in (select u.madv from qlbc.thanhvien u where username = :usn ) ";
                cmd.Parameters.Add(new OracleParameter("usn", thanhVien.USERNAME));
                var er = cmd.ExecuteReader();
                List<DSBauCu> dsBauCus = new List<DSBauCu>();
                while (er.Read())
                {
                    dsBauCus.Add(new DSBauCu()
                    {
                        ma = er.GetInt32(0),
                        name = er.GetString(1)
                    });
                }
                conn.Close();
                return dsBauCus;
            }
            catch (OracleException)
            {
                conn.Close();
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
