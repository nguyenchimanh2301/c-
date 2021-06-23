using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOKTX.DAOQLKT
{
    public class DAOSVvao
    {
        Desso30_NGUYENCHIMANHEntities ql = new Desso30_NGUYENCHIMANHEntities();
        public List<SINHVIENVAO> GetINHVIENVAOs()
        {
            return ql.SINHVIENVAOs.ToList<SINHVIENVAO>();
        }
        public List<SINHVIENVAO> GetmaSINHVIENVAOs(string ma)
        {
            return ql.SINHVIENVAOs.Where(u => u.masv == ma).ToList<SINHVIENVAO>();
        }
        public void delete(string mas)
        {
            ql.SINHVIENVAOs.RemoveRange(ql.SINHVIENVAOs.Where(u => u.masv == mas));
        }
        public void edit(SINHVIENVAO s)
        {
            var sv = ql.SINHVIENVAOs.Where(u => u.masv == s.masv).First<SINHVIENVAO>();
            sv.maphong = s.maphong;
            sv.hoten = s.hoten;
            sv.gioitinh = s.gioitinh;
            sv.ngaysinh = s.ngaysinh;
            sv.diachi = s.diachi;
            sv.sdt = s.sdt;
            sv.malop= s.malop;
            sv.ngaydangki = s.ngaydangki;
        }
        public void add(SINHVIENVAO s)
        {
            s.masv.Trim();
            s.hoten.Trim();
            s.gioitinh.Trim();
            s.malop.Trim();
            s.diachi.Trim();
            ql.SINHVIENVAOs.Add(s);
        }
        public void savechange()
        {
            ql.SaveChanges();
        }
    }
}

