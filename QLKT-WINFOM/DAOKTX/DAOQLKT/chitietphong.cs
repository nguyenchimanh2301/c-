using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOKTX.DAOQLKT
{
    public class chitietphong
    {
        Desso30_NGUYENCHIMANHEntities ql = new Desso30_NGUYENCHIMANHEntities();
        public List<chitietphongkt> GetChitietphongkt()
        {
            return ql.chitietphongkts.ToList<chitietphongkt>();

        }
        public List<chitietphongkt> GetmaChitietphongkt(string ma)
        {
            return ql.chitietphongkts.Where(u=>u.maphong==ma).ToList<chitietphongkt>();
        }
        public void delete(string ma)
        {
            ql.chitietphongkts.RemoveRange(ql.chitietphongkts.Where(u => u.maphong == ma));
        }
        public void edit(chitietphongkt c)
        {
            var chi = ql.chitietphongkts.Where(u => u.maphong == c.maphong).First<chitietphongkt>();
            chi.solsv = c.solsv;
            chi.controng = c.controng;
            chi.vitri = c.vitri;
        }
        public void add(chitietphongkt c)
        {
            ql.chitietphongkts.Add(c);
        }
        public void savechange()
        {
            ql.SaveChanges();
        }

    }
}
