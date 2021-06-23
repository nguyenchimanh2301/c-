using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAOKTX.DAOQLKT;
using DAOKTX;

namespace BUSKTX.BUSQLKT
{
   public class BUSSVra
    {
        DAOSVra dsv = new DAOSVra();
        public List<SINHVIENRA> GetSINHVIENRAs()
        {
           return dsv.GetSINHVIENRAs();
        }
        public List<SINHVIENRA> GetmaSINHVIENRAs(string ma)
        {
            return dsv.GetmaSINHVIENRAs(ma);
        }
        public void add(SINHVIENRA s)
        {
            dsv.add(s);
        }
        public void delete(string ma)
        {
            dsv.delete(ma);
        }
        public void edit(SINHVIENRA s)
        {
            dsv.edit(s);
        }
        public void save()
        {
            dsv.savechange();
        }
    }
}
