using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOKTX.DAOQLKT
{
   public class DAOphongkt
    {
        Desso30_NGUYENCHIMANHEntities ql = new Desso30_NGUYENCHIMANHEntities();
        public List<Phongkt> GetPhongkt()
        {
            return ql.Phongkts.ToList<Phongkt>();
        }
        public List<Phongkt> GetmaPhongkts(string ma)
        {
            return ql.Phongkts.Where(u => u.maphong == ma).ToList<Phongkt>();
        }
        public void delete(string map)
        {
          ql.Phongkts.RemoveRange(ql.Phongkts.Where(u => u.maphong == map));
        }
        public void edit(Phongkt p)
        {
            var phong = ql.Phongkts.Where(u => u.maphong.Trim() == p.maphong.Trim()).FirstOrDefault<Phongkt>();
            phong.tenday = p.tenday;
            phong.vitri = p.vitri;
            phong.loaiphong = p.loaiphong;
            phong.tinhtrang = p.tinhtrang;
            p = phong;
        }
        public void add(Phongkt p)
        {
            ql.Phongkts.Add(p);
        }
        public void savechange()
        {
            ql.SaveChanges();
        }
    }
}
