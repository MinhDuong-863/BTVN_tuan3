using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BTVNtuan3
{
    public class HocSinhDAO
    {
        DBConnetion dbConn = new DBConnetion();

        public DataTable LayDanhSachSinhVien()
        {
            string sqlStr = string.Format("SELECT *FROM HocSinh2");
            return dbConn.LayDanhSach(sqlStr);
        }
        public void Them(HocSinh hs)
        {
            string sqlStr1 = string.Format("INSERT INTO HocSinh2(MaHS, Ten, Quequan, Ngaysinh, Cmnd, Email, SDT) " +
                    "VALUES ('{0}', '{1}' , '{2}', '{3}', '{4}', '{5}', '{6}' )", hs.MaHS, hs.Ten, hs.QueQuan, hs.NgaySinh.ToShortDateString(), hs.Cmnd, hs.Email, hs.SDT);
            dbConn.ThucThi(sqlStr1);
        }
        public void Xoa(HocSinh hs)
        {
            string sqlStr1 = string.Format("DELETE FROM HocSinh2 WHERE MaHS = '{0}'", hs.MaHS);
            dbConn.ThucThi(sqlStr1);
        }
        public void Sua(HocSinh hs)
        { 
            string sqlStr = string.Format("UPDATE HocSinh2 SET Ten = '{0}',Quequan ='{1}', Ngaysinh ='{2}', Cmnd='{3}',Email = '{4}', SDT = '{5}' WHERE MaHS='{6}'",
                hs.Ten, hs.QueQuan, hs.NgaySinh.ToShortDateString(), hs.Cmnd, hs.Email, hs.SDT, hs.MaHS);
            dbConn.ThucThi(sqlStr);
        }
    }
}
