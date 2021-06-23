using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOKTX.DAOQLKT
{
   public class DAOhoadonp
    {
        Desso30_NGUYENCHIMANHEntities ql = new Desso30_NGUYENCHIMANHEntities();
        public List<Hoadonphong> GetHoadonphongs()
        {
            return ql.Hoadonphongs.ToList<Hoadonphong>();
        }
        public List<Hoadonphong> GetmaHoadonphongs(string ma)
        {
            return ql.Hoadonphongs.Where(u=>u.mahd==ma).ToList<Hoadonphong>();
        }
        public void add( Hoadonphong h)
        {
            ql.Hoadonphongs.Add(h);
        }
        public  void delete(string ma)
        {
            ql.Hoadonphongs.RemoveRange(ql.Hoadonphongs.Where(u => u.mahd == ma));
        }
        public void edit( Hoadonphong h)
        {
            var hd = ql.Hoadonphongs.Where(u => u.mahd == h.mahd).First<Hoadonphong>();
            hd.maphong = h.maphong;
            hd.tiendien = h.tiendien;
            hd.tiennuoc = h.tiennuoc;
            hd.tienvs = h.tienvs;
            hd.tongtien = hd.tongtien;
        }
        public void savechang()
        {
            ql.SaveChanges();
        }
    }
}
