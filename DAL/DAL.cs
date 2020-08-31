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
                cmd.CommandText = $"select VAITRO from QLBC.THANHVIEN where USERNAME = :usn";
                //cmd.CommandText = $"select VAITRO from QLBC.THANHVIEN where username = :usn";
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
        
    }
}
