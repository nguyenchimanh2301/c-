using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAOKTX;
using DAOKTX.DAOQLKT;

namespace BUSKTX.BUSQLKT
{
   public class BUShoadonP
    {
        DAOhoadonp hdp = new DAOhoadonp();
        public List<Hoadonphong> GetHoadonphongs()
        {
            return hdp.GetHoadonphongs();
        }
        public List<Hoadonphong> GetmaHoadonphongs(string ma)
        {
            return hdp.GetmaHoadonphongs(ma);
        }
        public void add(Hoadonphong h)
        {
            hdp.add(h);
        }
        public void delete(string ma)
        {
            hdp.delete(ma);
        }
        public void edit(Hoadonphong h)
        {
            hdp.edit(h);
        }
        public void save()
        {
            hdp.savechang();
        }
    }
}
