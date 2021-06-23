using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAOKTX;
using DAOKTX.DAOQLKT;

namespace BUSKTX.BUSQLKT
{
   public class BUSchitietphong
    {
        chitietphong ct = new chitietphong();
        public List<chitietphongkt> GetChitietphongkts()
        {
            return ct.GetChitietphongkt();

        }
        public List<chitietphongkt> GetChitietphongkts(string ma)
        {
            return ct.GetmaChitietphongkt(ma);
        }
        public void add(chitietphongkt c)
        {
            ct.add(c);
        }
        public void delete(string ma)
        {
            ct.delete(ma);
        }
        public void edit(chitietphongkt c)
        {
            ct.edit(c);
        }
        public void save()
        {
            ct.savechange();
        }
    }
}
