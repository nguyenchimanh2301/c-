using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOKTX.DAOQLKT
{
   public class DAOSVra
    {
        Desso30_NGUYENCHIMANHEntities ql = new Desso30_NGUYENCHIMANHEntities();
        public List<SINHVIENRA> GetSINHVIENRAs()
        {
            return ql.SINHVIENRAs.ToList<SINHVIENRA>();
        }
        public List<SINHVIENRA> GetmaSINHVIENRAs(string ma)
        {
            return ql.SINHVIENRAs.Where(u => u.masv == ma).ToList<SINHVIENRA>();
        }
        public void delete(string mas)
        {
            ql.SINHVIENRAs.RemoveRange(ql.SINHVIENRAs.Where(u => u.masv == mas));
        }
        public void edit(SINHVIENRA s)
        {
            var sv = ql.SINHVIENRAs.Where(u => u.masv == s.masv).First<SINHVIENRA>();
            sv.maphong = s.maphong;
            sv.hoten = s.hoten;
            sv.gioitinh = s.gioitinh;
            sv.ngaysinh = s.ngaysinh;
            sv.diachi = s.diachi;
            sv.sdt = s.sdt;
            sv.malop = s.malop;
            sv.ngayra = s.ngayra;
        }
        public void add(SINHVIENRA s)
        {
            ql.SINHVIENRAs.Add(s);
        }
        public void savechange()
        {
            ql.SaveChanges();
        }
    }
}

