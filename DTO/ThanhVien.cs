using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThanhVien
    {

        //public string username { get; set; }
        public string USERNAME { get; set; }
        public string password { get; set; }
        public string VAITRO { get; set; }
        

        //public int MATV { get; set; }
        //public string HOTEN { get; set; }
        //public string PHAI { get; set; }
        //public string QUEQUAN { get; set; }
        //public DateTime NGAYSINH { get; set; }
        //public string QUOCTICH { get; set; }
        //public string DCTHUONGTRU { get; set; }
        //public string DCTAMTRU { get; set; }     
        //public int MADV { get; set; }
        //public string VITRICONGTAC { get; set; }
        //public string NGHIPHEP { get; set; }
        //public string LYDONGHIPHEP { get; set; }
        //public int MALV { get; set; }

       


        //public ThanhVien(int matv, string hoten, string phai, string quequan, DateTime ngaysinh,
        //    string quoctich, string dcthuongtru, string dctamtru, string vaitro, int madv,
        //    string vtricongtac, string nghiphep, string lydonghiphep, string username, int malv,
        //    string un, string pss
        //    )
        //{
        //    username = un;
        //    password = pss;

        //    MATV = matv;
        //    HOTEN = hoten;
        //    PHAI = phai;
        //    QUEQUAN = quequan;
        //    NGAYSINH = ngaysinh;
        //    QUOCTICH = quoctich;
        //    DCTHUONGTRU = dcthuongtru;
        //    DCTHUONGTRU = DCTAMTRU;           
        //    MADV = madv;
        //    VITRICONGTAC = vtricongtac;
        //    NGHIPHEP = nghiphep;
        //    LYDONGHIPHEP = lydonghiphep;
        //    USERNAME = username;
        //    MALV = malv;
        //    VAITRO = "";
        //}
        public ThanhVien(string username,string pss)
        {
            USERNAME = username;
            password = pss;
            VAITRO = "";          
        }

        public void ClearUser()
        {
            USERNAME = "";
            password = "";
            VAITRO = "";

        }
    }
}
