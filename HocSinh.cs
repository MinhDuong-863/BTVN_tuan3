using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVNtuan3
{
    public class HocSinh
    {
        private string maHS;
        private string ten;
        private string queQuan;
        private DateTime ngaySinh;
        private string cmnd;
        private string email;
        private string sDT;

        public string MaHS { get { return maHS; } }
        public string Ten { get { return ten; } }
        public string QueQuan { get { return queQuan; } }
        public DateTime NgaySinh { get { return ngaySinh; } }
        public string Cmnd { get { return cmnd; } }
        public string Email { get { return email; } }
        public string SDT { get { return sDT; } }

        public HocSinh(string MaHS, string ten, string queQuan, DateTime ngaySinh, string cmnd, string email, string sDT)
        {
            this.maHS = MaHS;
            this.ten = ten;
            this.queQuan = queQuan;
            this.ngaySinh = ngaySinh;
            this.cmnd = cmnd;
            this.email = email;
            this.sDT = sDT;
        }
    }
}
