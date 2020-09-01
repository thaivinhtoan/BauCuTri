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
        public string USERNAME { get; set; }
        public string password { get; set; }
        public string VAITRO { get; set; }

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
