using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVNtuan3
{
    public class GiaoVienDAO
    {
        DBConnetion dbConn = new DBConnetion();

        public DataTable LayDanhSachGiaoVien()
        {
            string sqlStr = string.Format("SELECT *FROM GiaoVien2");
            return dbConn.LayDanhSach(sqlStr);
        }
        public void Them(GiaoVien gv)
        {
            string sqlStr1 = string.Format("INSERT INTO GiaoVien2(MaGV, Ten, Quequan, Ngaysinh, Cmnd, Email, SDT) " +
                    "VALUES ('{0}', '{1}' , '{2}', '{3}', '{4}', '{5}', '{6}' )", gv.MaGV, gv.Ten, gv.QueQuan, gv.NgaySinh.ToShortDateString(), gv.Cmnd, gv.Email, gv.SDT);
            dbConn.ThucThi(sqlStr1);
        }
        public void Xoa(GiaoVien gv)
        {
            string sqlStr1 = string.Format("DELETE FROM GiaoVien2 WHERE MaGV = '{0}'", gv.MaGV);
            dbConn.ThucThi(sqlStr1);
        }

        public void Sua(GiaoVien gv)
        {
            string sqlStr = string.Format("UPDATE GiaoVien2 SET Ten = '{0}',Quequan ='{1}', Ngaysinh ='{2}', Cmnd='{3}',Email = '{4}', SDT = '{5}' WHERE MaGV='{6}'",
                gv.Ten, gv.QueQuan, gv.NgaySinh.ToShortDateString(), gv.Cmnd, gv.Email, gv.SDT, gv.MaGV);
            dbConn.ThucThi(sqlStr);
        }
    }
}
