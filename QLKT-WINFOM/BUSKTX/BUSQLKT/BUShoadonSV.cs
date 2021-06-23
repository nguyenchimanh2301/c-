using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAOKTX;
using DAOKTX.DAOQLKT;

namespace BUSKTX.BUSQLKT
{
   public class BUShoadonSV
    {
        DAOhoadonsv daoh = new DAOhoadonsv();
        public List<Hoadonsv> GetHoadonsvs()
        {
            return daoh.GetHoadonsvs();
        }
        public List<Hoadonsv> GetmaHoadonsvs(string ma)
        {
            return daoh.GetmaHoadonsvs(ma);
        }
        public void add(Hoadonsv h)
        {
              daoh.add(h);
        }
        public void delete(string ma)
        {
            daoh.delete(ma);
        }
        public void edit(Hoadonsv h)
        {
            daoh.edit(h);
        }
        public void save()
        {
            daoh.savechange();
        }
    }
}
