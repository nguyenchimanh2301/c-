using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOKTX.DAOQLKT
{
   public class DAOhoadonsv
    {
        Desso30_NGUYENCHIMANHEntities ql = new Desso30_NGUYENCHIMANHEntities();
        public List<Hoadonsv> GetHoadonsvs()
        {
            return ql.Hoadonsvs.ToList<Hoadonsv>();
        }
        public List<Hoadonsv> GetmaHoadonsvs(string ma)
        {
            return ql.Hoadonsvs.Where(u=>u.mahd==ma).ToList<Hoadonsv>();
        }
        public void add(Hoadonsv h)
        {
            ql.Hoadonsvs.Add(h);
        }
        public void delete(string mahd)
        {
            ql.Hoadonsvs.RemoveRange(ql.Hoadonsvs.Where(u => u.mahd == mahd));
        } 
        public void edit(Hoadonsv h)
        {
            var hd = ql.Hoadonsvs.Where(u => u.mahd == h.mahd).First<Hoadonsv>();
            hd.masv = h.masv;
            hd.tienphong = h.tienphong;
            hd.tienkhac = h.tienkhac;
            hd.tongtien = h.tongtien;
        }
        public void savechange()
        {
            ql.SaveChanges();
        }
    }
}
